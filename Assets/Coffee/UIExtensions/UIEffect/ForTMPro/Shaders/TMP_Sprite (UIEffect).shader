Shader "TextMeshPro/Sprite (UIEffect)"
{
	Properties
	{
		_MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Color) = (1,1,1,1)
		
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255

		_ColorMask ("Color Mask", Float) = 15
		_ClipRect ("Clip Rect", vector) = (-32767, -32767, 32767, 32767)

		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
            
        _NoiseTex("Noise Texture (A)", 2D) = "white" {}
	}

	SubShader
	{
		Tags
		{ 
			"Queue"="Transparent" 
			"IgnoreProjector"="True" 
			"RenderType"="Transparent" 
			"PreviewType"="Plane"
			"CanUseSpriteAtlas"="True"
		}
		
		Stencil
		{
			Ref [_Stencil]
			Comp [_StencilComp]
			Pass [_StencilOp] 
			ReadMask [_StencilReadMask]
			WriteMask [_StencilWriteMask]
		}

		Cull Off
		Lighting Off
		ZWrite Off
		ZTest [unity_GUIZTestMode]
		Blend SrcAlpha OneMinusSrcAlpha
		ColorMask [_ColorMask]

		Pass
		{
		CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"
			#include "UnityUI.cginc"

			#pragma multi_compile __ UNITY_UI_CLIP_RECT
			#pragma multi_compile __ UNITY_UI_ALPHACLIP

			#pragma shader_feature __ GRAYSCALE SEPIA NEGA PIXEL 
			#pragma shader_feature __ ADD SUBTRACT FILL
			#pragma shader_feature __ FASTBLUR MEDIUMBLUR DETAILBLUR
			#pragma shader_feature __ EX
            
            #include "Assets/Coffee/UIExtensions/UIEffect/Shaders/UI-Effect.cginc"
			
			struct appdata_t
			{
				float4 vertex   : POSITION;
				float4 color    : COLOR;
				float2 texcoord : TEXCOORD0;
			#if EX
				float2	uvMask	: TEXCOORD2;
			#endif
			};

			struct v2f
			{
				float4 vertex   : SV_POSITION;
				fixed4 color    : COLOR;
				half2 texcoord  : TEXCOORD0;
				float4 worldPosition : TEXCOORD1;
                half   eParam	: TEXCOORD2;
			#if EX
				half4	uvMask	: TEXCOORD3;
			#endif
			};
			
			fixed4 _Color;
			fixed4 _TextureSampleAdd;
			float4 _ClipRect;

			v2f vert(appdata_t IN)
			{
				v2f OUT;
				OUT.worldPosition = IN.vertex;
				OUT.vertex = UnityObjectToClipPos(OUT.worldPosition);

				OUT.texcoord = UnpackToVec2(IN.texcoord.x) * 2 - 0.5;;
				
				#ifdef UNITY_HALF_TEXEL_OFFSET
				OUT.vertex.xy += (_ScreenParams.zw-1.0)*float2(-1,1);
				#endif
				
				OUT.color = IN.color * _Color;
                
                OUT.eParam = IN.texcoord.y;

				#if EX
				OUT.uvMask = half4(UnpackToVec2(IN.uvMask.x), UnpackToVec2(IN.uvMask.y));
				#endif

				return OUT;
			}

			sampler2D _MainTex;
			float4 _MainTex_TexelSize;
			
			fixed4 frag(v2f IN) : SV_Target
			{
				fixed4 param = tex2D(_ParamTex, float2(0.5, IN.eParam));
                fixed effectFactor = param.x;
                fixed colorFactor = param.y;
                fixed blurFactor = param.z;

				#if PIXEL
				half2 pixelSize = max(2, (1-effectFactor*0.95) * _MainTex_TexelSize.zw);
				IN.texcoord = round(IN.texcoord * pixelSize) / pixelSize;
				#endif

				#if defined(UI_BLUR) && EX
				half4 color = (Tex2DBlurring(_MainTex, IN.texcoord, blurFactor * _MainTex_TexelSize.xy * 2, IN.uvMask) + _TextureSampleAdd);
				#elif defined(UI_BLUR)
				half4 color = (Tex2DBlurring(_MainTex, IN.texcoord, blurFactor * _MainTex_TexelSize.xy * 2) + _TextureSampleAdd);
				#else
				half4 color = (tex2D(_MainTex, IN.texcoord) + _TextureSampleAdd);
				#endif

				color.a *= UnityGet2DClipping(IN.worldPosition.xy, _ClipRect);

				#if UNITY_UI_ALPHACLIP
				clip (color.a - 0.001);
				#endif

				#if defined (UI_TONE)
				color = ApplyToneEffect(color, effectFactor);
				#endif

				color = ApplyColorEffect(color, fixed4(IN.color.rgb, colorFactor));
				color.a *= IN.color.a;

				return color;
			}
		ENDCG
		}
	}
CustomEditor "Coffee.UIEffect.Editors.TMP_SDFShaderGUI"
}
