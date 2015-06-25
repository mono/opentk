//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
// Copyright 2013 Xamarin Inc
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//



using System;

namespace OpenTK.Graphics.ES20
{
public enum ActiveAttribType : int
{
Float = ((int)0X1406),
FloatVec2 = ((int)0X8b50),
FloatVec3 = ((int)0X8b51),
FloatVec4 = ((int)0X8b52),
FloatMat2 = ((int)0X8b5a),
FloatMat3 = ((int)0X8b5b),
FloatMat4 = ((int)0X8b5c),
}

public enum ActiveUniformType : int
{
Int = ((int)0X1404),
Float = ((int)0X1406),
FloatVec2 = ((int)0X8b50),
FloatVec3 = ((int)0X8b51),
FloatVec4 = ((int)0X8b52),
IntVec2 = ((int)0X8b53),
IntVec3 = ((int)0X8b54),
IntVec4 = ((int)0X8b55),
Bool = ((int)0X8b56),
BoolVec2 = ((int)0X8b57),
BoolVec3 = ((int)0X8b58),
BoolVec4 = ((int)0X8b59),
FloatMat2 = ((int)0X8b5a),
FloatMat3 = ((int)0X8b5b),
FloatMat4 = ((int)0X8b5c),
Sampler2D = ((int)0X8b5e),
SamplerCube = ((int)0X8b60),
}

public enum All : int
{
False = ((int)0),
NoError = ((int)0),
None = ((int)0),
Zero = ((int)0),
Points = ((int)0x0000),
PerfquerySingleContextIntel = ((int)0x00000000),
ColorBufferBit0Qcom = ((int)0x00000001),
PerfqueryGlobalContextIntel = ((int)0x00000001),
SyncFlushCommandsBitApple = ((int)0x00000001),
VertexShaderBitExt = ((int)0x00000001),
ColorBufferBit1Qcom = ((int)0x00000002),
ContextFlagDebugBitKhr = ((int)0x00000002),
FragmentShaderBitExt = ((int)0x00000002),
ColorBufferBit2Qcom = ((int)0x00000004),
GeometryShaderBitExt = ((int)0x00000004),
ColorBufferBit3Qcom = ((int)0x00000008),
TessControlShaderBitExt = ((int)0x00000008),
ColorBufferBit4Qcom = ((int)0x00000010),
TessEvaluationShaderBitExt = ((int)0x00000010),
ColorBufferBit5Qcom = ((int)0x00000020),
ColorBufferBit6Qcom = ((int)0x00000040),
ColorBufferBit7Qcom = ((int)0x00000080),
DepthBufferBit = ((int)0x00000100),
DepthBufferBit0Qcom = ((int)0x00000100),
DepthBufferBit1Qcom = ((int)0x00000200),
DepthBufferBit2Qcom = ((int)0x00000400),
StencilBufferBit = ((int)0x00000400),
DepthBufferBit3Qcom = ((int)0x00000800),
DepthBufferBit4Qcom = ((int)0x00001000),
DepthBufferBit5Qcom = ((int)0x00002000),
ColorBufferBit = ((int)0x00004000),
DepthBufferBit6Qcom = ((int)0x00004000),
CoverageBufferBitNv = ((int)0x00008000),
DepthBufferBit7Qcom = ((int)0x00008000),
Lines = ((int)0x0001),
MapReadBitExt = ((int)0x0001),
ImgTextureFormatBgra8888 = ((int)0X0001),
StencilBufferBit0Qcom = ((int)0x00010000),
LineLoop = ((int)0x0002),
MapWriteBitExt = ((int)0x0002),
StencilBufferBit1Qcom = ((int)0x00020000),
LineStrip = ((int)0x0003),
MapInvalidateRangeBitExt = ((int)0x0004),
Triangles = ((int)0x0004),
StencilBufferBit2Qcom = ((int)0x00040000),
TriangleStrip = ((int)0x0005),
TriangleFan = ((int)0x0006),
QuadsExt = ((int)0x0007),
MapInvalidateBufferBitExt = ((int)0x0008),
StencilBufferBit3Qcom = ((int)0x00080000),
LinesAdjacencyExt = ((int)0x000A),
LineStripAdjacencyExt = ((int)0x000B),
TrianglesAdjacencyExt = ((int)0x000C),
TriangleStripAdjacencyExt = ((int)0x000D),
PatchesExt = ((int)0x000E),
MapFlushExplicitBitExt = ((int)0x0010),
StencilBufferBit4Qcom = ((int)0x00100000),
MapUnsynchronizedBitExt = ((int)0x0020),
StencilBufferBit5Qcom = ((int)0x00200000),
StencilBufferBit6Qcom = ((int)0x00400000),
StencilBufferBit7Qcom = ((int)0x00800000),
MultisampleBufferBit0Qcom = ((int)0x01000000),
Never = ((int)0x0200),
MultisampleBufferBit1Qcom = ((int)0x02000000),
Less = ((int)0x0201),
Equal = ((int)0x0202),
Lequal = ((int)0x0203),
Greater = ((int)0x0204),
Notequal = ((int)0x0205),
Gequal = ((int)0x0206),
Always = ((int)0x0207),
SrcColor = ((int)0x0300),
OneMinusSrcColor = ((int)0x0301),
SrcAlpha = ((int)0x0302),
OneMinusSrcAlpha = ((int)0x0303),
DstAlpha = ((int)0x0304),
OneMinusDstAlpha = ((int)0x0305),
DstColor = ((int)0x0306),
OneMinusDstColor = ((int)0x0307),
SrcAlphaSaturate = ((int)0x0308),
MultisampleBufferBit2Qcom = ((int)0x04000000),
Front = ((int)0x0404),
Back = ((int)0x0405),
FrontAndBack = ((int)0x0408),
InvalidEnum = ((int)0x0500),
InvalidValue = ((int)0x0501),
InvalidOperation = ((int)0x0502),
StackOverflowKhr = ((int)0x0503),
StackUnderflowKhr = ((int)0x0504),
OutOfMemory = ((int)0x0505),
InvalidFramebufferOperation = ((int)0x0506),
MultisampleBufferBit3Qcom = ((int)0x08000000),
Cw = ((int)0x0900),
Ccw = ((int)0x0901),
LineWidth = ((int)0x0B21),
CullFace = ((int)0x0B44),
CullFaceMode = ((int)0x0B45),
FrontFace = ((int)0x0B46),
DepthRange = ((int)0x0B70),
DepthTest = ((int)0x0B71),
DepthWritemask = ((int)0x0B72),
DepthClearValue = ((int)0x0B73),
DepthFunc = ((int)0x0B74),
StencilTest = ((int)0x0B90),
StencilClearValue = ((int)0x0B91),
StencilFunc = ((int)0x0B92),
StencilValueMask = ((int)0x0B93),
StencilFail = ((int)0x0B94),
StencilPassDepthFail = ((int)0x0B95),
StencilPassDepthPass = ((int)0x0B96),
StencilRef = ((int)0x0B97),
StencilWritemask = ((int)0x0B98),
Viewport = ((int)0x0BA2),
AlphaTestQcom = ((int)0x0BC0),
AlphaTestFuncQcom = ((int)0x0BC1),
AlphaTestRefQcom = ((int)0x0BC2),
Dither = ((int)0x0BD0),
Blend = ((int)0x0BE2),
DrawBufferExt = ((int)0x0C01),
ReadBufferExt = ((int)0x0C02),
ReadBufferNv = ((int)0x0C02),
ScissorBox = ((int)0x0C10),
ScissorTest = ((int)0x0C11),
ColorClearValue = ((int)0x0C22),
ColorWritemask = ((int)0x0C23),
UnpackRowLengthExt = ((int)0x0CF2),
UnpackSkipRowsExt = ((int)0x0CF3),
UnpackSkipPixelsExt = ((int)0x0CF4),
UnpackAlignment = ((int)0x0CF5),
PackAlignment = ((int)0x0D05),
MaxTextureSize = ((int)0x0D33),
MaxViewportDims = ((int)0x0D3A),
SubpixelBits = ((int)0x0D50),
RedBits = ((int)0x0D52),
GreenBits = ((int)0x0D53),
BlueBits = ((int)0x0D54),
AlphaBits = ((int)0x0D55),
DepthBits = ((int)0x0D56),
StencilBits = ((int)0x0D57),
Texture2D = ((int)0x0DE1),
MultisampleBufferBit4Qcom = ((int)0x10000000),
TextureBorderColorExt = ((int)0x1004),
TextureBorderColorNv = ((int)0x1004),
DontCare = ((int)0x1100),
Fastest = ((int)0x1101),
Nicest = ((int)0x1102),
Byte = ((int)0x1400),
UnsignedByte = ((int)0x1401),
Short = ((int)0x1402),
UnsignedShort = ((int)0x1403),
Int = ((int)0x1404),
UnsignedInt = ((int)0x1405),
Float = ((int)0x1406),
Fixed = ((int)0x140C),
XorNv = ((int)0x1506),
Invert = ((int)0x150A),
Texture = ((int)0x1702),
ColorExt = ((int)0x1800),
DepthExt = ((int)0x1801),
StencilExt = ((int)0x1802),
StencilIndex = ((int)0x1901),
StencilIndexOes = ((int)0x1901),
DepthComponent = ((int)0x1902),
RedExt = ((int)0x1903),
RedNv = ((int)0x1903),
GreenNv = ((int)0x1904),
BlueNv = ((int)0x1905),
Alpha = ((int)0x1906),
Rgb = ((int)0x1907),
Rgba = ((int)0x1908),
Luminance = ((int)0x1909),
LuminanceAlpha = ((int)0x190A),
Keep = ((int)0x1E00),
Replace = ((int)0x1E01),
Incr = ((int)0x1E02),
Decr = ((int)0x1E03),
Vendor = ((int)0x1F00),
Renderer = ((int)0x1F01),
Version = ((int)0x1F02),
Extensions = ((int)0x1F03),
MultisampleBufferBit5Qcom = ((int)0x20000000),
Nearest = ((int)0x2600),
Linear = ((int)0x2601),
NearestMipmapNearest = ((int)0x2700),
LinearMipmapNearest = ((int)0x2701),
NearestMipmapLinear = ((int)0x2702),
LinearMipmapLinear = ((int)0x2703),
TextureMagFilter = ((int)0x2800),
TextureMinFilter = ((int)0x2801),
TextureWrapS = ((int)0x2802),
TextureWrapT = ((int)0x2803),
Repeat = ((int)0x2901),
PolygonOffsetUnits = ((int)0x2A00),
MultisampleBufferBit6Qcom = ((int)0x40000000),
MultisampleBufferBit7Qcom = unchecked((int)0x80000000),
ConstantColor = ((int)0x8001),
OneMinusConstantColor = ((int)0x8002),
ConstantAlpha = ((int)0x8003),
OneMinusConstantAlpha = ((int)0x8004),
BlendColor = ((int)0x8005),
FuncAdd = ((int)0x8006),
Min = ((int)0x8007),
MinExt = ((int)0x8007),
Max = ((int)0x8008),
MaxExt = ((int)0x8008),
BlendEquation = ((int)0x8009),
BlendEquationRgb = ((int)0X8009),
FuncSubtract = ((int)0x800A),
FuncReverseSubtract = ((int)0x800B),
UnsignedShort4444 = ((int)0x8033),
UnsignedShort5551 = ((int)0x8034),
PolygonOffsetFill = ((int)0x8037),
PolygonOffsetFactor = ((int)0x8038),
Alpha8Ext = ((int)0x803C),
Alpha8Oes = ((int)0x803C),
Luminance8Ext = ((int)0x8040),
Luminance8Oes = ((int)0x8040),
Luminance4Alpha4Oes = ((int)0x8043),
Luminance8Alpha8Ext = ((int)0x8045),
Luminance8Alpha8Oes = ((int)0x8045),
Rgb8Oes = ((int)0x8051),
Rgb10Ext = ((int)0x8052),
Rgba4 = ((int)0x8056),
Rgba4Oes = ((int)0x8056),
Rgb5A1 = ((int)0x8057),
Rgb5A1Oes = ((int)0x8057),
Rgba8Oes = ((int)0x8058),
Rgb10A2Ext = ((int)0x8059),
TextureBinding2D = ((int)0x8069),
TextureBinding3DOes = ((int)0x806A),
Texture3DOes = ((int)0x806F),
TextureWrapROes = ((int)0x8072),
Max3DTextureSizeOes = ((int)0x8073),
VertexArrayKhr = ((int)0x8074),
SampleAlphaToCoverage = ((int)0x809E),
SampleCoverage = ((int)0x80A0),
SampleBuffers = ((int)0x80A8),
Samples = ((int)0x80A9),
SampleCoverageValue = ((int)0x80AA),
SampleCoverageInvert = ((int)0x80AB),
BlendDstRgb = ((int)0x80C8),
BlendSrcRgb = ((int)0x80C9),
BlendDstAlpha = ((int)0x80CA),
BlendSrcAlpha = ((int)0x80CB),
BgraExt = ((int)0x80E1),
BgraImg = ((int)0x80E1),
ClampToBorderExt = ((int)0x812D),
ClampToBorderNv = ((int)0x812D),
ClampToEdge = ((int)0x812F),
TextureMaxLevelApple = ((int)0x813D),
GenerateMipmapHint = ((int)0x8192),
DepthComponent16 = ((int)0x81A5),
DepthComponent16Oes = ((int)0x81A5),
DepthComponent24Oes = ((int)0x81A6),
DepthComponent32Oes = ((int)0x81A7),
FramebufferAttachmentColorEncodingExt = ((int)0x8210),
FramebufferAttachmentComponentTypeExt = ((int)0x8211),
FramebufferUndefinedOes = ((int)0x8219),
PrimitiveRestartForPatchesSupported = ((int)0x8221),
RgExt = ((int)0x8227),
R8Ext = ((int)0x8229),
Rg8Ext = ((int)0x822B),
R16fExt = ((int)0x822D),
R32fExt = ((int)0x822E),
Rg16fExt = ((int)0x822F),
Rg32fExt = ((int)0x8230),
DebugOutputSynchronousKhr = ((int)0x8242),
DebugNextLoggedMessageLengthKhr = ((int)0x8243),
DebugCallbackFunctionKhr = ((int)0x8244),
DebugCallbackUserParamKhr = ((int)0x8245),
DebugSourceApiKhr = ((int)0x8246),
DebugSourceWindowSystemKhr = ((int)0x8247),
DebugSourceShaderCompilerKhr = ((int)0x8248),
DebugSourceThirdPartyKhr = ((int)0x8249),
DebugSourceApplicationKhr = ((int)0x824A),
DebugSourceOtherKhr = ((int)0x824B),
DebugTypeErrorKhr = ((int)0x824C),
DebugTypeDeprecatedBehaviorKhr = ((int)0x824D),
DebugTypeUndefinedBehaviorKhr = ((int)0x824E),
DebugTypePortabilityKhr = ((int)0x824F),
DebugTypePerformanceKhr = ((int)0x8250),
DebugTypeOtherKhr = ((int)0x8251),
LoseContextOnResetExt = ((int)0x8252),
GuiltyContextResetExt = ((int)0x8253),
InnocentContextResetExt = ((int)0x8254),
UnknownContextResetExt = ((int)0x8255),
ResetNotificationStrategyExt = ((int)0x8256),
ProgramSeparableExt = ((int)0x8258),
ActiveProgramExt = ((int)0x8259),
ProgramPipelineBindingExt = ((int)0x825A),
LayerProvokingVertexExt = ((int)0x825E),
UndefinedVertexExt = ((int)0x8260),
NoResetNotificationExt = ((int)0x8261),
DebugTypeMarkerKhr = ((int)0x8268),
DebugTypePushGroupKhr = ((int)0x8269),
DebugTypePopGroupKhr = ((int)0x826A),
DebugSeverityNotificationKhr = ((int)0x826B),
MaxDebugGroupStackDepthKhr = ((int)0x826C),
DebugGroupStackDepthKhr = ((int)0x826D),
TextureViewMinLevelExt = ((int)0x82DB),
TextureViewNumLevelsExt = ((int)0x82DC),
TextureViewMinLayerExt = ((int)0x82DD),
TextureViewNumLayersExt = ((int)0x82DE),
TextureImmutableLevels = ((int)0x82DF),
BufferKhr = ((int)0x82E0),
ShaderKhr = ((int)0x82E1),
ProgramKhr = ((int)0x82E2),
QueryKhr = ((int)0x82E3),
Sampler = ((int)0x82E6),
SamplerKhr = ((int)0x82E6),
MaxLabelLengthKhr = ((int)0x82E8),
UnsignedShort565 = ((int)0x8363),
UnsignedShort4444RevExt = ((int)0x8365),
UnsignedShort4444RevImg = ((int)0x8365),
UnsignedShort1555RevExt = ((int)0x8366),
UnsignedInt2101010RevExt = ((int)0x8368),
MirroredRepeat = ((int)0x8370),
CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
CompressedRgbaS3tcDxt3Angle = ((int)0x83F2),
CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
CompressedRgbaS3tcDxt5Angle = ((int)0x83F3),
CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
PerfqueryDonotFlushIntel = ((int)0x83F9),
PerfqueryFlushIntel = ((int)0x83FA),
PerfqueryWaitIntel = ((int)0x83FB),
AliasedPointSizeRange = ((int)0x846D),
AliasedLineWidthRange = ((int)0x846E),
Texture0 = ((int)0x84C0),
Texture1 = ((int)0x84C1),
Texture2 = ((int)0x84C2),
Texture3 = ((int)0x84C3),
Texture4 = ((int)0x84C4),
Texture5 = ((int)0x84C5),
Texture6 = ((int)0x84C6),
Texture7 = ((int)0x84C7),
Texture8 = ((int)0x84C8),
Texture9 = ((int)0x84C9),
Texture10 = ((int)0x84CA),
Texture11 = ((int)0x84CB),
Texture12 = ((int)0x84CC),
Texture13 = ((int)0x84CD),
Texture14 = ((int)0x84CE),
Texture15 = ((int)0x84CF),
Texture16 = ((int)0x84D0),
Texture17 = ((int)0x84D1),
Texture18 = ((int)0x84D2),
Texture19 = ((int)0x84D3),
Texture20 = ((int)0x84D4),
Texture21 = ((int)0x84D5),
Texture22 = ((int)0x84D6),
Texture23 = ((int)0x84D7),
Texture24 = ((int)0x84D8),
Texture25 = ((int)0x84D9),
Texture26 = ((int)0x84DA),
Texture27 = ((int)0x84DB),
Texture28 = ((int)0x84DC),
Texture29 = ((int)0x84DD),
Texture30 = ((int)0x84DE),
Texture31 = ((int)0x84DF),
ActiveTexture = ((int)0x84E0),
MaxRenderbufferSize = ((int)0x84E8),
AllCompletedNv = ((int)0x84F2),
FenceStatusNv = ((int)0x84F3),
FenceConditionNv = ((int)0x84F4),
DepthStencilOes = ((int)0x84F9),
UnsignedInt248Oes = ((int)0x84FA),
TextureMaxAnisotropyExt = ((int)0x84FE),
MaxTextureMaxAnisotropyExt = ((int)0x84FF),
IncrWrap = ((int)0x8507),
DecrWrap = ((int)0x8508),
TextureCubeMap = ((int)0x8513),
TextureBindingCubeMap = ((int)0x8514),
TextureCubeMapPositiveX = ((int)0x8515),
TextureCubeMapNegativeX = ((int)0x8516),
TextureCubeMapPositiveY = ((int)0x8517),
TextureCubeMapNegativeY = ((int)0x8518),
TextureCubeMapPositiveZ = ((int)0x8519),
TextureCubeMapNegativeZ = ((int)0x851A),
MaxCubeMapTextureSize = ((int)0x851C),
VertexArrayBindingOes = ((int)0x85B5),
UnsignedShort88Apple = ((int)0x85BA),
UnsignedShort88RevApple = ((int)0x85BB),
VertexAttribArrayEnabled = ((int)0x8622),
VertexAttribArraySize = ((int)0x8623),
VertexAttribArrayStride = ((int)0x8624),
VertexAttribArrayType = ((int)0x8625),
CurrentVertexAttrib = ((int)0x8626),
VertexAttribArrayPointer = ((int)0x8645),
NumCompressedTextureFormats = ((int)0x86A2),
CompressedTextureFormats = ((int)0x86A3),
Z400BinaryAmd = ((int)0x8740),
ProgramBinaryLengthOes = ((int)0x8741),
BufferSize = ((int)0x8764),
BufferUsage = ((int)0x8765),
AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
GL_3DcXAmd = ((int)0x87F9),
Gl3DcXAmd = ((int)0x87F9),
GL_3DcXyAmd = ((int)0x87FA),
Gl3DcXyAmd = ((int)0x87FA),
NumProgramBinaryFormatsOes = ((int)0x87FE),
ProgramBinaryFormatsOes = ((int)0x87FF),
StencilBackFunc = ((int)0x8800),
StencilBackFail = ((int)0x8801),
StencilBackPassDepthFail = ((int)0x8802),
StencilBackPassDepthPass = ((int)0x8803),
Rgba32fExt = ((int)0x8814),
Rgb32fExt = ((int)0x8815),
Alpha32fExt = ((int)0x8816),
Luminance32fExt = ((int)0x8818),
LuminanceAlpha32fExt = ((int)0x8819),
Rgba16fExt = ((int)0x881A),
Rgb16fExt = ((int)0x881B),
Alpha16fExt = ((int)0x881C),
Luminance16fExt = ((int)0x881E),
LuminanceAlpha16fExt = ((int)0x881F),
WriteonlyRenderingQcom = ((int)0x8823),
MaxDrawBuffersExt = ((int)0x8824),
MaxDrawBuffersNv = ((int)0x8824),
DrawBuffer0Ext = ((int)0x8825),
DrawBuffer0Nv = ((int)0x8825),
DrawBuffer1Ext = ((int)0x8826),
DrawBuffer1Nv = ((int)0x8826),
DrawBuffer2Ext = ((int)0x8827),
DrawBuffer2Nv = ((int)0x8827),
DrawBuffer3Ext = ((int)0x8828),
DrawBuffer3Nv = ((int)0x8828),
DrawBuffer4Ext = ((int)0x8829),
DrawBuffer4Nv = ((int)0x8829),
DrawBuffer5Ext = ((int)0x882A),
DrawBuffer5Nv = ((int)0x882A),
DrawBuffer6Ext = ((int)0x882B),
DrawBuffer6Nv = ((int)0x882B),
DrawBuffer7Ext = ((int)0x882C),
DrawBuffer7Nv = ((int)0x882C),
DrawBuffer8Ext = ((int)0x882D),
DrawBuffer8Nv = ((int)0x882D),
DrawBuffer9Ext = ((int)0x882E),
DrawBuffer9Nv = ((int)0x882E),
DrawBuffer10Ext = ((int)0x882F),
DrawBuffer10Nv = ((int)0x882F),
DrawBuffer11Ext = ((int)0x8830),
DrawBuffer11Nv = ((int)0x8830),
DrawBuffer12Ext = ((int)0x8831),
DrawBuffer12Nv = ((int)0x8831),
DrawBuffer13Ext = ((int)0x8832),
DrawBuffer13Nv = ((int)0x8832),
DrawBuffer14Ext = ((int)0x8833),
DrawBuffer14Nv = ((int)0x8833),
DrawBuffer15Ext = ((int)0x8834),
DrawBuffer15Nv = ((int)0x8834),
BlendEquationAlpha = ((int)0x883D),
TextureCompareModeExt = ((int)0x884C),
TextureCompareFuncExt = ((int)0x884D),
CompareRefToTextureExt = ((int)0x884E),
QueryCounterBitsExt = ((int)0x8864),
CurrentQueryExt = ((int)0x8865),
QueryResultExt = ((int)0x8866),
QueryResultAvailableExt = ((int)0x8867),
MaxVertexAttribs = ((int)0x8869),
VertexAttribArrayNormalized = ((int)0x886A),
MaxTessControlInputComponentsExt = ((int)0x886C),
MaxTessEvaluationInputComponentsExt = ((int)0x886D),
MaxTextureImageUnits = ((int)0x8872),
GeometryShaderInvocationsExt = ((int)0x887F),
ArrayBuffer = ((int)0x8892),
ElementArrayBuffer = ((int)0x8893),
ArrayBufferBinding = ((int)0x8894),
ElementArrayBufferBinding = ((int)0x8895),
VertexAttribArrayBufferBinding = ((int)0x889F),
WriteOnlyOes = ((int)0x88B9),
BufferAccessOes = ((int)0x88BB),
BufferMappedOes = ((int)0x88BC),
BufferMapPointerOes = ((int)0x88BD),
TimeElapsedExt = ((int)0x88BF),
StreamDraw = ((int)0x88E0),
StaticDraw = ((int)0x88E4),
DynamicDraw = ((int)0x88E8),
Etc1Srgb8Nv = ((int)0x88EE),
Depth24Stencil8Oes = ((int)0x88F0),
VertexAttribArrayDivisorAngle = ((int)0x88FE),
VertexAttribArrayDivisorExt = ((int)0x88FE),
VertexAttribArrayDivisorNv = ((int)0x88FE),
GeometryLinkedVerticesOutExt = ((int)0x8916),
GeometryLinkedInputTypeExt = ((int)0x8917),
GeometryLinkedOutputTypeExt = ((int)0x8918),
Rgb422Apple = ((int)0x8A1F),
MaxGeometryUniformBlocksExt = ((int)0x8A2C),
MaxCombinedGeometryUniformComponentsExt = ((int)0x8A32),
TextureSrgbDecodeExt = ((int)0x8A48),
DecodeExt = ((int)0x8A49),
SkipDecodeExt = ((int)0x8A4A),
ProgramPipelineObjectExt = ((int)0x8A4F),
RgbRaw422Apple = ((int)0x8A51),
FragmentShaderDiscardsSamplesExt = ((int)0x8A52),
SyncObjectApple = ((int)0x8A53),
CompressedSrgbPvrtc2Bppv1Ext = ((int)0x8A54),
CompressedSrgbPvrtc4Bppv1Ext = ((int)0x8A55),
CompressedSrgbAlphaPvrtc2Bppv1Ext = ((int)0x8A56),
CompressedSrgbAlphaPvrtc4Bppv1Ext = ((int)0x8A57),
FragmentShader = ((int)0x8B30),
VertexShader = ((int)0x8B31),
ProgramObjectExt = ((int)0x8B40),
ShaderObjectExt = ((int)0x8B48),
MaxVertexTextureImageUnits = ((int)0x8B4C),
MaxCombinedTextureImageUnits = ((int)0x8B4D),
ShaderType = ((int)0x8B4F),
FloatVec2 = ((int)0x8B50),
FloatVec3 = ((int)0x8B51),
FloatVec4 = ((int)0x8B52),
IntVec2 = ((int)0x8B53),
IntVec3 = ((int)0x8B54),
IntVec4 = ((int)0x8B55),
Bool = ((int)0x8B56),
BoolVec2 = ((int)0x8B57),
BoolVec3 = ((int)0x8B58),
BoolVec4 = ((int)0x8B59),
FloatMat2 = ((int)0x8B5A),
FloatMat3 = ((int)0x8B5B),
FloatMat4 = ((int)0x8B5C),
Sampler2D = ((int)0x8B5E),
Sampler3DOes = ((int)0x8B5F),
SamplerCube = ((int)0x8B60),
Sampler2DShadowExt = ((int)0x8B62),
FloatMat2x3Nv = ((int)0x8B65),
FloatMat2x4Nv = ((int)0x8B66),
FloatMat3x2Nv = ((int)0x8B67),
FloatMat3x4Nv = ((int)0x8B68),
FloatMat4x2Nv = ((int)0x8B69),
FloatMat4x3Nv = ((int)0x8B6A),
DeleteStatus = ((int)0x8B80),
CompileStatus = ((int)0x8B81),
LinkStatus = ((int)0x8B82),
ValidateStatus = ((int)0x8B83),
InfoLogLength = ((int)0x8B84),
AttachedShaders = ((int)0x8B85),
ActiveUniforms = ((int)0x8B86),
ActiveUniformMaxLength = ((int)0x8B87),
ShaderSourceLength = ((int)0x8B88),
ActiveAttributes = ((int)0x8B89),
ActiveAttributeMaxLength = ((int)0x8B8A),
FragmentShaderDerivativeHintOes = ((int)0x8B8B),
ShadingLanguageVersion = ((int)0x8B8C),
CurrentProgram = ((int)0x8B8D),
Palette4Rgb8Oes = ((int)0x8B90),
Palette4Rgba8Oes = ((int)0x8B91),
Palette4R5G6B5Oes = ((int)0x8B92),
Palette4Rgba4Oes = ((int)0x8B93),
Palette4Rgb5A1Oes = ((int)0x8B94),
Palette8Rgb8Oes = ((int)0x8B95),
Palette8Rgba8Oes = ((int)0x8B96),
Palette8R5G6B5Oes = ((int)0x8B97),
Palette8Rgba4Oes = ((int)0x8B98),
Palette8Rgb5A1Oes = ((int)0x8B99),
ImplementationColorReadType = ((int)0x8B9A),
ImplementationColorReadFormat = ((int)0x8B9B),
CounterTypeAmd = ((int)0x8BC0),
CounterRangeAmd = ((int)0x8BC1),
UnsignedInt64Amd = ((int)0x8BC2),
PercentageAmd = ((int)0x8BC3),
PerfmonResultAvailableAmd = ((int)0x8BC4),
PerfmonResultSizeAmd = ((int)0x8BC5),
PerfmonResultAmd = ((int)0x8BC6),
TextureWidthQcom = ((int)0x8BD2),
TextureHeightQcom = ((int)0x8BD3),
TextureDepthQcom = ((int)0x8BD4),
TextureInternalFormatQcom = ((int)0x8BD5),
TextureFormatQcom = ((int)0x8BD6),
TextureTypeQcom = ((int)0x8BD7),
TextureImageValidQcom = ((int)0x8BD8),
TextureNumLevelsQcom = ((int)0x8BD9),
TextureTargetQcom = ((int)0x8BDA),
TextureObjectValidQcom = ((int)0x8BDB),
StateRestore = ((int)0x8BDC),
CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
SgxBinaryImg = ((int)0x8C0A),
UnsignedNormalizedExt = ((int)0x8C17),
MaxGeometryTextureImageUnitsExt = ((int)0x8C29),
TextureBufferBindingExt = ((int)0x8C2A),
TextureBufferExt = ((int)0x8C2A),
MaxTextureBufferSizeExt = ((int)0x8C2B),
TextureBindingBufferExt = ((int)0x8C2C),
TextureBufferDataStoreBindingExt = ((int)0x8C2D),
AnySamplesPassedExt = ((int)0x8C2F),
SampleShadingOes = ((int)0x8C36),
MinSampleShadingValueOes = ((int)0x8C37),
SrgbExt = ((int)0x8C40),
Srgb8Nv = ((int)0x8C41),
SrgbAlphaExt = ((int)0x8C42),
Srgb8Alpha8Ext = ((int)0x8C43),
SluminanceAlphaNv = ((int)0x8C44),
Sluminance8Alpha8Nv = ((int)0x8C45),
SluminanceNv = ((int)0x8C46),
Sluminance8Nv = ((int)0x8C47),
CompressedSrgbS3tcDxt1Nv = ((int)0x8C4C),
CompressedSrgbAlphaS3tcDxt1Nv = ((int)0x8C4D),
CompressedSrgbAlphaS3tcDxt3Nv = ((int)0x8C4E),
CompressedSrgbAlphaS3tcDxt5Nv = ((int)0x8C4F),
PrimitivesGeneratedExt = ((int)0x8C87),
AtcRgbAmd = ((int)0x8C92),
AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
StencilBackRef = ((int)0x8CA3),
StencilBackValueMask = ((int)0x8CA4),
StencilBackWritemask = ((int)0x8CA5),
DrawFramebufferBindingAngle = ((int)0x8CA6),
DrawFramebufferBindingApple = ((int)0x8CA6),
DrawFramebufferBindingNv = ((int)0x8CA6),
FramebufferBinding = ((int)0x8CA6),
RenderbufferBinding = ((int)0x8CA7),
ReadFramebufferAngle = ((int)0x8CA8),
ReadFramebufferApple = ((int)0x8CA8),
ReadFramebufferNv = ((int)0x8CA8),
DrawFramebufferAngle = ((int)0x8CA9),
DrawFramebufferApple = ((int)0x8CA9),
DrawFramebufferNv = ((int)0x8CA9),
ReadFramebufferBindingAngle = ((int)0x8CAA),
ReadFramebufferBindingApple = ((int)0x8CAA),
ReadFramebufferBindingNv = ((int)0x8CAA),
RenderbufferSamplesAngle = ((int)0x8CAB),
RenderbufferSamplesApple = ((int)0x8CAB),
RenderbufferSamplesExt = ((int)0x8CAB),
RenderbufferSamplesNv = ((int)0x8CAB),
FramebufferAttachmentObjectType = ((int)0x8CD0),
FramebufferAttachmentObjectName = ((int)0x8CD1),
FramebufferAttachmentTextureLevel = ((int)0x8CD2),
FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3),
FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4),
FramebufferComplete = ((int)0x8CD5),
FramebufferIncompleteAttachment = ((int)0x8CD6),
FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
FramebufferIncompleteDimensions = ((int)0x8CD9),
FramebufferUnsupported = ((int)0x8CDD),
MaxColorAttachmentsExt = ((int)0x8CDF),
MaxColorAttachmentsNv = ((int)0x8CDF),
ColorAttachment0 = ((int)0x8CE0),
ColorAttachment0Ext = ((int)0x8CE0),
ColorAttachment0Nv = ((int)0x8CE0),
ColorAttachment1Ext = ((int)0x8CE1),
ColorAttachment1Nv = ((int)0x8CE1),
ColorAttachment2Ext = ((int)0x8CE2),
ColorAttachment2Nv = ((int)0x8CE2),
ColorAttachment3Ext = ((int)0x8CE3),
ColorAttachment3Nv = ((int)0x8CE3),
ColorAttachment4Ext = ((int)0x8CE4),
ColorAttachment4Nv = ((int)0x8CE4),
ColorAttachment5Ext = ((int)0x8CE5),
ColorAttachment5Nv = ((int)0x8CE5),
ColorAttachment6Ext = ((int)0x8CE6),
ColorAttachment6Nv = ((int)0x8CE6),
ColorAttachment7Ext = ((int)0x8CE7),
ColorAttachment7Nv = ((int)0x8CE7),
ColorAttachment8Ext = ((int)0x8CE8),
ColorAttachment8Nv = ((int)0x8CE8),
ColorAttachment9Ext = ((int)0x8CE9),
ColorAttachment9Nv = ((int)0x8CE9),
ColorAttachment10Ext = ((int)0x8CEA),
ColorAttachment10Nv = ((int)0x8CEA),
ColorAttachment11Ext = ((int)0x8CEB),
ColorAttachment11Nv = ((int)0x8CEB),
ColorAttachment12Ext = ((int)0x8CEC),
ColorAttachment12Nv = ((int)0x8CEC),
ColorAttachment13Ext = ((int)0x8CED),
ColorAttachment13Nv = ((int)0x8CED),
ColorAttachment14Ext = ((int)0x8CEE),
ColorAttachment14Nv = ((int)0x8CEE),
ColorAttachment15Ext = ((int)0x8CEF),
ColorAttachment15Nv = ((int)0x8CEF),
DepthAttachment = ((int)0x8D00),
StencilAttachment = ((int)0x8D20),
Framebuffer = ((int)0x8D40),
Renderbuffer = ((int)0x8D41),
RenderbufferWidth = ((int)0x8D42),
RenderbufferHeight = ((int)0x8D43),
RenderbufferInternalFormat = ((int)0x8D44),
StencilIndex1Oes = ((int)0x8D46),
StencilIndex4Oes = ((int)0x8D47),
StencilIndex8 = ((int)0x8D48),
StencilIndex8Oes = ((int)0x8D48),
RenderbufferRedSize = ((int)0x8D50),
RenderbufferGreenSize = ((int)0x8D51),
RenderbufferBlueSize = ((int)0x8D52),
RenderbufferAlphaSize = ((int)0x8D53),
RenderbufferDepthSize = ((int)0x8D54),
RenderbufferStencilSize = ((int)0x8D55),
FramebufferIncompleteMultisampleAngle = ((int)0x8D56),
FramebufferIncompleteMultisampleApple = ((int)0x8D56),
FramebufferIncompleteMultisampleExt = ((int)0x8D56),
FramebufferIncompleteMultisampleNv = ((int)0x8D56),
MaxSamplesAngle = ((int)0x8D57),
MaxSamplesApple = ((int)0x8D57),
MaxSamplesExt = ((int)0x8D57),
MaxSamplesNv = ((int)0x8D57),
HalfFloatOes = ((int)0x8D61),
Rgb565 = ((int)0x8D62),
Rgb565Oes = ((int)0x8D62),
Etc1Rgb8Oes = ((int)0x8D64),
TextureExternalOes = ((int)0x8D65),
SamplerExternalOes = ((int)0x8D66),
TextureBindingExternalOes = ((int)0x8D67),
RequiredTextureImageUnitsOes = ((int)0x8D68),
AnySamplesPassedConservativeExt = ((int)0x8D6A),
FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C),
FramebufferAttachmentLayeredExt = ((int)0x8DA7),
FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8),
FramebufferSrgbExt = ((int)0x8DB9),
SamplerBufferExt = ((int)0x8DC2),
Sampler2DArrayShadowNv = ((int)0x8DC4),
SamplerCubeShadowNv = ((int)0x8DC5),
IntSamplerBufferExt = ((int)0x8DD0),
UnsignedIntSamplerBufferExt = ((int)0x8DD8),
GeometryShaderExt = ((int)0x8DD9),
MaxGeometryUniformComponentsExt = ((int)0x8DDF),
MaxGeometryOutputVerticesExt = ((int)0x8DE0),
MaxGeometryTotalOutputComponentsExt = ((int)0x8DE1),
LowFloat = ((int)0x8DF0),
MediumFloat = ((int)0x8DF1),
HighFloat = ((int)0x8DF2),
LowInt = ((int)0x8DF3),
MediumInt = ((int)0x8DF4),
HighInt = ((int)0x8DF5),
UnsignedInt1010102Oes = ((int)0x8DF6),
Int1010102Oes = ((int)0x8DF7),
ShaderBinaryFormats = ((int)0x8DF8),
NumShaderBinaryFormats = ((int)0x8DF9),
ShaderCompiler = ((int)0x8DFA),
MaxVertexUniformVectors = ((int)0x8DFB),
MaxVaryingVectors = ((int)0x8DFC),
MaxFragmentUniformVectors = ((int)0x8DFD),
MaxCombinedTessControlUniformComponentsExt = ((int)0x8E1E),
MaxCombinedTessEvaluationUniformComponentsExt = ((int)0x8E1F),
TransformFeedback = ((int)0x8E22),
TimestampExt = ((int)0x8E28),
DepthComponent16NonlinearNv = ((int)0x8E2C),
FirstVertexConventionExt = ((int)0x8E4D),
LastVertexConventionExt = ((int)0x8E4E),
MaxGeometryShaderInvocationsExt = ((int)0x8E5A),
MinFragmentInterpolationOffsetOes = ((int)0x8E5B),
MaxFragmentInterpolationOffsetOes = ((int)0x8E5C),
FragmentInterpolationOffsetBitsOes = ((int)0x8E5D),
PatchVerticesExt = ((int)0x8E72),
TessControlOutputVerticesExt = ((int)0x8E75),
TessGenModeExt = ((int)0x8E76),
TessGenSpacingExt = ((int)0x8E77),
TessGenVertexOrderExt = ((int)0x8E78),
TessGenPointModeExt = ((int)0x8E79),
IsolinesExt = ((int)0x8E7A),
FractionalOddExt = ((int)0x8E7B),
FractionalEvenExt = ((int)0x8E7C),
MaxPatchVerticesExt = ((int)0x8E7D),
MaxTessGenLevelExt = ((int)0x8E7E),
MaxTessControlUniformComponentsExt = ((int)0x8E7F),
MaxTessEvaluationUniformComponentsExt = ((int)0x8E80),
MaxTessControlTextureImageUnitsExt = ((int)0x8E81),
MaxTessEvaluationTextureImageUnitsExt = ((int)0x8E82),
MaxTessControlOutputComponentsExt = ((int)0x8E83),
MaxTessPatchComponentsExt = ((int)0x8E84),
MaxTessControlTotalOutputComponentsExt = ((int)0x8E85),
MaxTessEvaluationOutputComponentsExt = ((int)0x8E86),
TessEvaluationShaderExt = ((int)0x8E87),
TessControlShaderExt = ((int)0x8E88),
MaxTessControlUniformBlocksExt = ((int)0x8E89),
MaxTessEvaluationUniformBlocksExt = ((int)0x8E8A),
CoverageComponentNv = ((int)0x8ED0),
CoverageComponent4Nv = ((int)0x8ED1),
CoverageAttachmentNv = ((int)0x8ED2),
CoverageBuffersNv = ((int)0x8ED3),
CoverageSamplesNv = ((int)0x8ED4),
CoverageAllFragmentsNv = ((int)0x8ED5),
CoverageEdgeFragmentsNv = ((int)0x8ED6),
CoverageAutomaticNv = ((int)0x8ED7),
CopyReadBufferNv = ((int)0x8F36),
CopyWriteBufferNv = ((int)0x8F37),
MaliShaderBinaryArm = ((int)0x8F60),
MaliProgramBinaryArm = ((int)0x8F61),
MaxShaderPixelLocalStorageFastSizeExt = ((int)0x8F63),
ShaderPixelLocalStorageExt = ((int)0x8F64),
FetchPerSampleArm = ((int)0x8F65),
FragmentShaderFramebufferFetchMrtArm = ((int)0x8F66),
MaxShaderPixelLocalStorageSizeExt = ((int)0x8F67),
PerfmonGlobalModeQcom = ((int)0x8FA0),
BinningControlHintQcom = ((int)0x8FB0),
CpuOptimizedQcom = ((int)0x8FB1),
GpuOptimizedQcom = ((int)0x8FB2),
RenderDirectToFramebufferQcom = ((int)0x8FB3),
GpuDisjointExt = ((int)0x8FBB),
ShaderBinaryViv = ((int)0x8FC4),
TextureCubeMapArrayExt = ((int)0x9009),
TextureBindingCubeMapArrayExt = ((int)0x900A),
SamplerCubeMapArrayExt = ((int)0x900C),
SamplerCubeMapArrayShadowExt = ((int)0x900D),
IntSamplerCubeMapArrayExt = ((int)0x900E),
UnsignedIntSamplerCubeMapArrayExt = ((int)0x900F),
ImageBufferExt = ((int)0x9051),
ImageCubeMapArrayExt = ((int)0x9054),
IntImageBufferExt = ((int)0x905C),
IntImageCubeMapArrayExt = ((int)0x905F),
UnsignedIntImageBufferExt = ((int)0x9067),
UnsignedIntImageCubeMapArrayExt = ((int)0x906A),
MaxTessControlImageUniformsExt = ((int)0x90CB),
MaxTessEvaluationImageUniformsExt = ((int)0x90CC),
MaxGeometryImageUniformsExt = ((int)0x90CD),
MaxGeometryShaderStorageBlocksExt = ((int)0x90D7),
MaxTessControlShaderStorageBlocksExt = ((int)0x90D8),
MaxTessEvaluationShaderStorageBlocksExt = ((int)0x90D9),
ColorAttachmentExt = ((int)0x90F0),
MultiviewExt = ((int)0x90F1),
MaxMultiviewBuffersExt = ((int)0x90F2),
ContextRobustAccessExt = ((int)0x90F3),
Texture2DMultisampleArrayOes = ((int)0x9102),
TextureBinding2DMultisampleArrayOes = ((int)0x9105),
Sampler2DMultisampleArrayOes = ((int)0x910B),
IntSampler2DMultisampleArrayOes = ((int)0x910C),
UnsignedIntSampler2DMultisampleArrayOes = ((int)0x910D),
MaxServerWaitTimeoutApple = ((int)0x9111),
ObjectTypeApple = ((int)0x9112),
SyncConditionApple = ((int)0x9113),
SyncStatusApple = ((int)0x9114),
SyncFlagsApple = ((int)0x9115),
SyncFenceApple = ((int)0x9116),
SyncGpuCommandsCompleteApple = ((int)0x9117),
UnsignaledApple = ((int)0x9118),
SignaledApple = ((int)0x9119),
AlreadySignaledApple = ((int)0x911A),
TimeoutExpiredApple = ((int)0x911B),
ConditionSatisfiedApple = ((int)0x911C),
WaitFailedApple = ((int)0x911D),
MaxGeometryInputComponentsExt = ((int)0x9123),
MaxGeometryOutputComponentsExt = ((int)0x9124),
TextureImmutableFormatExt = ((int)0x912F),
SgxProgramBinaryImg = ((int)0x9130),
RenderbufferSamplesImg = ((int)0x9133),
FramebufferIncompleteMultisampleImg = ((int)0x9134),
MaxSamplesImg = ((int)0x9135),
TextureSamplesImg = ((int)0x9136),
CompressedRgbaPvrtc2Bppv2Img = ((int)0x9137),
CompressedRgbaPvrtc4Bppv2Img = ((int)0x9138),
MaxDebugMessageLengthKhr = ((int)0x9143),
MaxDebugLoggedMessagesKhr = ((int)0x9144),
DebugLoggedMessagesKhr = ((int)0x9145),
DebugSeverityHighKhr = ((int)0x9146),
DebugSeverityMediumKhr = ((int)0x9147),
DebugSeverityLowKhr = ((int)0x9148),
BufferObjectExt = ((int)0x9151),
QueryObjectExt = ((int)0x9153),
VertexArrayObjectExt = ((int)0x9154),
TextureBufferOffsetExt = ((int)0x919D),
TextureBufferSizeExt = ((int)0x919E),
TextureBufferOffsetAlignmentExt = ((int)0x919F),
ShaderBinaryDmp = ((int)0x9250),
GccsoShaderBinaryFj = ((int)0x9260),
BlendPremultipliedSrcNv = ((int)0x9280),
BlendOverlapNv = ((int)0x9281),
UncorrelatedNv = ((int)0x9282),
DisjointNv = ((int)0x9283),
ConjointNv = ((int)0x9284),
BlendAdvancedCoherentKhr = ((int)0x9285),
BlendAdvancedCoherentNv = ((int)0x9285),
SrcNv = ((int)0x9286),
DstNv = ((int)0x9287),
SrcOverNv = ((int)0x9288),
DstOverNv = ((int)0x9289),
SrcInNv = ((int)0x928A),
DstInNv = ((int)0x928B),
SrcOutNv = ((int)0x928C),
DstOutNv = ((int)0x928D),
SrcAtopNv = ((int)0x928E),
DstAtopNv = ((int)0x928F),
PlusNv = ((int)0x9291),
PlusDarkerNv = ((int)0x9292),
MultiplyKhr = ((int)0x9294),
MultiplyNv = ((int)0x9294),
ScreenKhr = ((int)0x9295),
ScreenNv = ((int)0x9295),
OverlayKhr = ((int)0x9296),
OverlayNv = ((int)0x9296),
DarkenKhr = ((int)0x9297),
DarkenNv = ((int)0x9297),
LightenKhr = ((int)0x9298),
LightenNv = ((int)0x9298),
ColordodgeKhr = ((int)0x9299),
ColordodgeNv = ((int)0x9299),
ColorburnKhr = ((int)0x929A),
ColorburnNv = ((int)0x929A),
HardlightKhr = ((int)0x929B),
HardlightNv = ((int)0x929B),
SoftlightKhr = ((int)0x929C),
SoftlightNv = ((int)0x929C),
DifferenceKhr = ((int)0x929E),
DifferenceNv = ((int)0x929E),
MinusNv = ((int)0x929F),
ExclusionKhr = ((int)0x92A0),
ExclusionNv = ((int)0x92A0),
ContrastNv = ((int)0x92A1),
InvertRgbNv = ((int)0x92A3),
LineardodgeNv = ((int)0x92A4),
LinearburnNv = ((int)0x92A5),
VividlightNv = ((int)0x92A6),
LinearlightNv = ((int)0x92A7),
PinlightNv = ((int)0x92A8),
HardmixNv = ((int)0x92A9),
HslHueKhr = ((int)0x92AD),
HslHueNv = ((int)0x92AD),
HslSaturationKhr = ((int)0x92AE),
HslSaturationNv = ((int)0x92AE),
HslColorKhr = ((int)0x92AF),
HslColorNv = ((int)0x92AF),
HslLuminosityKhr = ((int)0x92B0),
HslLuminosityNv = ((int)0x92B0),
PlusClampedNv = ((int)0x92B1),
PlusClampedAlphaNv = ((int)0x92B2),
MinusClampedNv = ((int)0x92B3),
InvertOvgNv = ((int)0x92B4),
PrimitiveBoundingBoxExt = ((int)0x92BE),
MaxTessControlAtomicCounterBuffersExt = ((int)0x92CD),
MaxTessEvaluationAtomicCounterBuffersExt = ((int)0x92CE),
MaxGeometryAtomicCounterBuffersExt = ((int)0x92CF),
MaxTessControlAtomicCountersExt = ((int)0x92D3),
MaxTessEvaluationAtomicCountersExt = ((int)0x92D4),
MaxGeometryAtomicCountersExt = ((int)0x92D5),
DebugOutputKhr = ((int)0x92E0),
IsPerPatchExt = ((int)0x92E7),
ReferencedByTessControlShaderExt = ((int)0x9307),
ReferencedByTessEvaluationShaderExt = ((int)0x9308),
ReferencedByGeometryShaderExt = ((int)0x9309),
FramebufferDefaultLayersExt = ((int)0x9312),
MaxFramebufferLayersExt = ((int)0x9317),
TranslatedShaderSourceLengthAngle = ((int)0x93A0),
Bgra8Ext = ((int)0x93A1),
TextureUsageAngle = ((int)0x93A2),
FramebufferAttachmentAngle = ((int)0x93A3),
PackReverseRowOrderAngle = ((int)0x93A4),
ProgramBinaryAngle = ((int)0x93A6),
CompressedRgbaAstc4X4Khr = ((int)0x93B0),
CompressedRgbaAstc5X4Khr = ((int)0x93B1),
CompressedRgbaAstc5X5Khr = ((int)0x93B2),
CompressedRgbaAstc6X5Khr = ((int)0x93B3),
CompressedRgbaAstc6X6Khr = ((int)0x93B4),
CompressedRgbaAstc8X5Khr = ((int)0x93B5),
CompressedRgbaAstc8X6Khr = ((int)0x93B6),
CompressedRgbaAstc8X8Khr = ((int)0x93B7),
CompressedRgbaAstc10X5Khr = ((int)0x93B8),
CompressedRgbaAstc10X6Khr = ((int)0x93B9),
CompressedRgbaAstc10X8Khr = ((int)0x93BA),
CompressedRgbaAstc10X10Khr = ((int)0x93BB),
CompressedRgbaAstc12X10Khr = ((int)0x93BC),
CompressedRgbaAstc12X12Khr = ((int)0x93BD),
CompressedRgbaAstc3X3x3Oes = ((int)0x93C0),
CompressedRgbaAstc4X3x3Oes = ((int)0x93C1),
CompressedRgbaAstc4X4x3Oes = ((int)0x93C2),
CompressedRgbaAstc4X4x4Oes = ((int)0x93C3),
CompressedRgbaAstc5X4x4Oes = ((int)0x93C4),
CompressedRgbaAstc5X5x4Oes = ((int)0x93C5),
CompressedRgbaAstc5X5x5Oes = ((int)0x93C6),
CompressedRgbaAstc6X5x5Oes = ((int)0x93C7),
CompressedRgbaAstc6X6x5Oes = ((int)0x93C8),
CompressedRgbaAstc6X6x6Oes = ((int)0x93C9),
CompressedSrgb8Alpha8Astc4X4Khr = ((int)0x93D0),
CompressedSrgb8Alpha8Astc5X4Khr = ((int)0x93D1),
CompressedSrgb8Alpha8Astc5X5Khr = ((int)0x93D2),
CompressedSrgb8Alpha8Astc6X5Khr = ((int)0x93D3),
CompressedSrgb8Alpha8Astc6X6Khr = ((int)0x93D4),
CompressedSrgb8Alpha8Astc8X5Khr = ((int)0x93D5),
CompressedSrgb8Alpha8Astc8X6Khr = ((int)0x93D6),
CompressedSrgb8Alpha8Astc8X8Khr = ((int)0x93D7),
CompressedSrgb8Alpha8Astc10X5Khr = ((int)0x93D8),
CompressedSrgb8Alpha8Astc10X6Khr = ((int)0x93D9),
CompressedSrgb8Alpha8Astc10X8Khr = ((int)0x93DA),
CompressedSrgb8Alpha8Astc10X10Khr = ((int)0x93DB),
CompressedSrgb8Alpha8Astc12X10Khr = ((int)0x93DC),
CompressedSrgb8Alpha8Astc12X12Khr = ((int)0x93DD),
CompressedSrgb8Alpha8Astc3X3x3Oes = ((int)0x93E0),
CompressedSrgb8Alpha8Astc4X3x3Oes = ((int)0x93E1),
CompressedSrgb8Alpha8Astc4X4x3Oes = ((int)0x93E2),
CompressedSrgb8Alpha8Astc4X4x4Oes = ((int)0x93E3),
CompressedSrgb8Alpha8Astc5X4x4Oes = ((int)0x93E4),
CompressedSrgb8Alpha8Astc5X5x4Oes = ((int)0x93E5),
CompressedSrgb8Alpha8Astc5X5x5Oes = ((int)0x93E6),
CompressedSrgb8Alpha8Astc6X5x5Oes = ((int)0x93E7),
CompressedSrgb8Alpha8Astc6X6x5Oes = ((int)0x93E8),
CompressedSrgb8Alpha8Astc6X6x6Oes = ((int)0x93E9),
CompressedSrgbAlphaPvrtc2Bppv2Img = ((int)0x93F0),
CompressedSrgbAlphaPvrtc4Bppv2Img = ((int)0x93F1),
PerfqueryCounterEventIntel = ((int)0x94F0),
PerfqueryCounterDurationNormIntel = ((int)0x94F1),
PerfqueryCounterDurationRawIntel = ((int)0x94F2),
PerfqueryCounterThroughputIntel = ((int)0x94F3),
PerfqueryCounterRawIntel = ((int)0x94F4),
PerfqueryCounterTimestampIntel = ((int)0x94F5),
PerfqueryCounterDataUint32Intel = ((int)0x94F8),
PerfqueryCounterDataUint64Intel = ((int)0x94F9),
PerfqueryCounterDataFloatIntel = ((int)0x94FA),
PerfqueryCounterDataDoubleIntel = ((int)0x94FB),
PerfqueryCounterDataBool32Intel = ((int)0x94FC),
PerfqueryQueryNameLengthMaxIntel = ((int)0x94FD),
PerfqueryCounterNameLengthMaxIntel = ((int)0x94FE),
PerfqueryCounterDescLengthMaxIntel = ((int)0x94FF),
PerfqueryGpaExtendedCountersIntel = ((int)0x9500),
AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
AmdCompressed3DcTexture = ((int)1),
AmdCompressedAtcTexture = ((int)1),
AmdPerformanceMonitor = ((int)1),
AmdProgramBinaryZ400 = ((int)1),
EsVersion20 = ((int)1),
ExtBlendMinmax = ((int)1),
ExtDiscardFramebuffer = ((int)1),
ExtMultiDrawArrays = ((int)1),
ExtReadFormatBgra = ((int)1),
ExtTextureCompressionDxt1 = ((int)1),
ExtTextureFilterAnisotropic = ((int)1),
ExtTextureFormatBgra8888 = ((int)1),
ExtTextureType2101010Rev = ((int)1),
ImgMultisampledRenderToTexture = ((int)1),
ImgProgramBinary = ((int)1),
ImgReadFormat = ((int)1),
ImgShaderBinary = ((int)1),
ImgTextureCompressionPvrtc = ((int)1),
NvCoverageSample = ((int)1),
NvDepthNonlinear = ((int)1),
NvFence = ((int)1),
OesCompressedEtc1Rgb8Texture = ((int)1),
OesCompressedPalettedTexture = ((int)1),
OesDepth24 = ((int)1),
OesDepth32 = ((int)1),
OesDepthTexture = ((int)1),
OesEglImage = ((int)1),
OesEglImageExternal = ((int)1),
OesElementIndexUint = ((int)1),
OesFboRenderMipmap = ((int)1),
OesFragmentPrecisionHigh = ((int)1),
OesGetProgramBinary = ((int)1),
OesMapbuffer = ((int)1),
OesPackedDepthStencil = ((int)1),
OesRgb8Rgba8 = ((int)1),
OesStandardDerivatives = ((int)1),
OesStencil1 = ((int)1),
OesStencil4 = ((int)1),
OesTexture3D = ((int)1),
OesTextureFloat = ((int)1),
OesTextureFloatLinear = ((int)1),
OesTextureHalfFloat = ((int)1),
OesTextureHalfFloatLinear = ((int)1),
OesTextureNpot = ((int)1),
OesVertexArrayObject = ((int)1),
OesVertexHalfFloat = ((int)1),
OesVertexType1010102 = ((int)1),
One = ((int)1),
QcomDriverControl = ((int)1),
QcomExtendedGet = ((int)1),
QcomExtendedGet2 = ((int)1),
QcomPerfmonGlobalMode = ((int)1),
QcomTiledRendering = ((int)1),
QcomWriteonlyRendering = ((int)1),
True = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Amdcompressed3Dctexture : int
{
GL_3DcXAmd = ((int)0x87F9),
GL_3DcXyAmd = ((int)0x87FA),
AmdCompressed3DcTexture = ((int)1),
}

public enum AmdCompressed3Dctexture : int
{
Gl3DcXAmd = ((int)0x87F9),
Gl3DcXyAmd = ((int)0x87FA),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum AmdcompressedAtctexture : int
{
AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
AtcRgbAmd = ((int)0x8C92),
AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
AmdCompressedAtcTexture = ((int)1),
}

public enum AmdCompressedAtctexture : int
{
AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE),
AtcRgbAmd = ((int)0x8C92),
AtcRgbaExplicitAlphaAmd = ((int)0x8C93),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum AmdperformanceMonitor : int
{
CounterTypeAmd = ((int)0x8BC0),
CounterRangeAmd = ((int)0x8BC1),
UnsignedInt64Amd = ((int)0x8BC2),
PercentageAmd = ((int)0x8BC3),
PerfmonResultAvailableAmd = ((int)0x8BC4),
PerfmonResultSizeAmd = ((int)0x8BC5),
PerfmonResultAmd = ((int)0x8BC6),
AmdPerformanceMonitor = ((int)1),
}

public enum AmdPerformanceMonitor : int
{
CounterTypeAmd = ((int)0x8BC0),
CounterRangeAmd = ((int)0x8BC1),
UnsignedInt64Amd = ((int)0x8BC2),
PercentageAmd = ((int)0x8BC3),
PerfmonResultAvailableAmd = ((int)0x8BC4),
PerfmonResultSizeAmd = ((int)0x8BC5),
PerfmonResultAmd = ((int)0x8BC6),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum AmdprogramBinaryZ400 : int
{
Z400BinaryAmd = ((int)0x8740),
AmdProgramBinaryZ400 = ((int)1),
}

public enum AmdProgramBinaryZ400 : int
{
Z400BinaryAmd = ((int)0x8740),
}

public enum AngleFramebufferBlit : int
{
DrawFramebufferBindingAngle = ((int)0x8CA6),
ReadFramebufferAngle = ((int)0x8CA8),
DrawFramebufferAngle = ((int)0x8CA9),
ReadFramebufferBindingAngle = ((int)0x8CAA),
}

public enum AngleFramebufferMultisample : int
{
RenderbufferSamplesAngle = ((int)0x8CAB),
FramebufferIncompleteMultisampleAngle = ((int)0x8D56),
MaxSamplesAngle = ((int)0x8D57),
}

public enum AngleInstancedArrays : int
{
VertexAttribArrayDivisorAngle = ((int)0x88FE),
}

public enum AnglePackReverseRowOrder : int
{
PackReverseRowOrderAngle = ((int)0x93A4),
}

public enum AngleProgramBinary : int
{
ProgramBinaryAngle = ((int)0x93A6),
}

public enum AngleTextureCompressionDxt3 : int
{
CompressedRgbaS3tcDxt3Angle = ((int)0x83F2),
}

public enum AngleTextureCompressionDxt5 : int
{
CompressedRgbaS3tcDxt5Angle = ((int)0x83F3),
}

public enum AngleTextureUsage : int
{
TextureUsageAngle = ((int)0x93A2),
FramebufferAttachmentAngle = ((int)0x93A3),
}

public enum AngleTranslatedShaderSource : int
{
TranslatedShaderSourceLengthAngle = ((int)0x93A0),
}

public enum AppleFramebufferMultisample : int
{
DrawFramebufferBindingApple = ((int)0x8CA6),
ReadFramebufferApple = ((int)0x8CA8),
DrawFramebufferApple = ((int)0x8CA9),
ReadFramebufferBindingApple = ((int)0x8CAA),
RenderbufferSamplesApple = ((int)0x8CAB),
FramebufferIncompleteMultisampleApple = ((int)0x8D56),
MaxSamplesApple = ((int)0x8D57),
}

public enum AppleRgb422 : int
{
UnsignedShort88Apple = ((int)0x85BA),
UnsignedShort88RevApple = ((int)0x85BB),
Rgb422Apple = ((int)0x8A1F),
RgbRaw422Apple = ((int)0x8A51),
}

public enum AppleSync : int
{
SyncFlushCommandsBitApple = ((int)0x00000001),
SyncObjectApple = ((int)0x8A53),
MaxServerWaitTimeoutApple = ((int)0x9111),
ObjectTypeApple = ((int)0x9112),
SyncConditionApple = ((int)0x9113),
SyncStatusApple = ((int)0x9114),
SyncFlagsApple = ((int)0x9115),
SyncFenceApple = ((int)0x9116),
SyncGpuCommandsCompleteApple = ((int)0x9117),
UnsignaledApple = ((int)0x9118),
SignaledApple = ((int)0x9119),
AlreadySignaledApple = ((int)0x911A),
TimeoutExpiredApple = ((int)0x911B),
ConditionSatisfiedApple = ((int)0x911C),
WaitFailedApple = ((int)0x911D),
TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF),
}

public enum AppleTextureFormatBgra8888 : int
{
BgraExt = ((int)0x80E1),
Bgra8Ext = ((int)0x93A1),
}

public enum AppleTextureMaxLevel : int
{
TextureMaxLevelApple = ((int)0x813D),
}

public enum ArmMaliProgramBinary : int
{
MaliProgramBinaryArm = ((int)0x8F61),
}

public enum ArmMaliShaderBinary : int
{
MaliShaderBinaryArm = ((int)0x8F60),
}

public enum ArmShaderFramebufferFetch : int
{
FetchPerSampleArm = ((int)0x8F65),
FragmentShaderFramebufferFetchMrtArm = ((int)0x8F66),
}

public enum BeginMode : int
{
Points = ((int)0x0000),
Lines = ((int)0x0001),
LineLoop = ((int)0x0002),
LineStrip = ((int)0x0003),
Triangles = ((int)0x0004),
TriangleStrip = ((int)0x0005),
TriangleFan = ((int)0x0006),
}

public enum BlendEquationMode : int
{
FuncAdd = ((int)0X8006),
FuncSubtract = ((int)0X800a),
FuncReverseSubtract = ((int)0X800b),
}

public enum BlendEquationSeparate : int
{
FuncAdd = ((int)0x8006),
BlendEquation = ((int)0x8009),
BlendEquationAlpha = ((int)0x883D),
}

public enum BlendingFactorDest : int
{
Zero = ((int)0),
SrcColor = ((int)0x0300),
OneMinusSrcColor = ((int)0x0301),
SrcAlpha = ((int)0x0302),
OneMinusSrcAlpha = ((int)0x0303),
DstAlpha = ((int)0x0304),
OneMinusDstAlpha = ((int)0x0305),
DstColor = ((int)0X0306),
OneMinusDstColor = ((int)0X0307),
SrcAlphaSaturate = ((int)0X0308),
ConstantColor = ((int)0X8001),
OneMinusConstantColor = ((int)0X8002),
ConstantAlpha = ((int)0X8003),
OneMinusConstantAlpha = ((int)0X8004),
One = ((int)1),
}

public enum BlendingFactorSrc : int
{
Zero = ((int)0),
SrcColor = ((int)0X0300),
OneMinusSrcColor = ((int)0X0301),
SrcAlpha = ((int)0X0302),
OneMinusSrcAlpha = ((int)0X0303),
DstAlpha = ((int)0X0304),
OneMinusDstAlpha = ((int)0X0305),
DstColor = ((int)0x0306),
OneMinusDstColor = ((int)0x0307),
SrcAlphaSaturate = ((int)0x0308),
ConstantColor = ((int)0X8001),
OneMinusConstantColor = ((int)0X8002),
ConstantAlpha = ((int)0X8003),
OneMinusConstantAlpha = ((int)0X8004),
One = ((int)1),
}

public enum BlendSubtract : int
{
FuncSubtract = ((int)0x800A),
FuncReverseSubtract = ((int)0x800B),
}

public enum Boolean : int
{
False = ((int)0),
True = ((int)1),
}

public enum BufferObjects : int
{
CurrentVertexAttrib = ((int)0x8626),
BufferSize = ((int)0x8764),
BufferUsage = ((int)0x8765),
ArrayBuffer = ((int)0x8892),
ElementArrayBuffer = ((int)0x8893),
ArrayBufferBinding = ((int)0x8894),
ElementArrayBufferBinding = ((int)0x8895),
StreamDraw = ((int)0x88E0),
StaticDraw = ((int)0x88E4),
DynamicDraw = ((int)0x88E8),
}

public enum BufferParameterName : int
{
BufferSize = ((int)0X8764),
BufferUsage = ((int)0X8765),
}

public enum BufferTarget : int
{
ArrayBuffer = ((int)0X8892),
ElementArrayBuffer = ((int)0X8893),
}

public enum BufferUsage : int
{
StreamDraw = ((int)0X88e0),
StaticDraw = ((int)0X88e4),
DynamicDraw = ((int)0X88e8),
}

[Flags]
public enum ClearBufferMask : int
{
DepthBufferBit = ((int)0x00000100),
StencilBufferBit = ((int)0x00000400),
ColorBufferBit = ((int)0x00004000),
}

public enum CullFaceMode : int
{
Front = ((int)0x0404),
Back = ((int)0x0405),
FrontAndBack = ((int)0x0408),
}

public enum DataType : int
{
Byte = ((int)0x1400),
UnsignedByte = ((int)0x1401),
Short = ((int)0x1402),
UnsignedShort = ((int)0x1403),
Int = ((int)0x1404),
UnsignedInt = ((int)0x1405),
Float = ((int)0x1406),
Fixed = ((int)0x140C),
}

public enum DepthFunction : int
{
Never = ((int)0X0200),
Less = ((int)0X0201),
Equal = ((int)0X0202),
Lequal = ((int)0X0203),
Greater = ((int)0X0204),
Notequal = ((int)0X0205),
Gequal = ((int)0X0206),
Always = ((int)0X0207),
}

public enum DmpshaderBinary : int
{
ShaderBinaryDmp = ((int)0x9250),
}

public enum DrawElementsType : int
{
UnsignedByte = ((int)0X1401),
UnsignedShort = ((int)0X1403),
UnsignedInt = ((int)0X1405),
}

public enum EnableCap : int
{
CullFace = ((int)0x0B44),
DepthTest = ((int)0x0B71),
StencilTest = ((int)0x0B90),
Dither = ((int)0x0BD0),
Blend = ((int)0x0BE2),
ScissorTest = ((int)0x0C11),
Texture2D = ((int)0x0DE1),
PolygonOffsetFill = ((int)0x8037),
SampleAlphaToCoverage = ((int)0x809E),
SampleCoverage = ((int)0x80A0),
}

public enum ErrorCode : int
{
NoError = ((int)0),
InvalidEnum = ((int)0x0500),
InvalidValue = ((int)0x0501),
InvalidOperation = ((int)0x0502),
OutOfMemory = ((int)0x0505),
InvalidFramebufferOperation = ((int)0X0506),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExtblendMinmax : int
{
MinExt = ((int)0x8007),
MaxExt = ((int)0x8008),
ExtBlendMinmax = ((int)1),
}

public enum ExtBlendMinmax : int
{
MinExt = ((int)0x8007),
MaxExt = ((int)0x8008),
}

public enum ExtColorBufferHalfFloat : int
{
FramebufferAttachmentComponentTypeExt = ((int)0x8211),
R16fExt = ((int)0x822D),
Rg16fExt = ((int)0x822F),
Rgba16fExt = ((int)0x881A),
Rgb16fExt = ((int)0x881B),
UnsignedNormalizedExt = ((int)0x8C17),
}

public enum ExtDebugLabel : int
{
ProgramPipelineObjectExt = ((int)0x8A4F),
ProgramObjectExt = ((int)0x8B40),
ShaderObjectExt = ((int)0x8B48),
TransformFeedback = ((int)0x8E22),
BufferObjectExt = ((int)0x9151),
QueryObjectExt = ((int)0x9153),
VertexArrayObjectExt = ((int)0x9154),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExtdiscardFramebuffer : int
{
ColorExt = ((int)0x1800),
DepthExt = ((int)0x1801),
StencilExt = ((int)0x1802),
ExtDiscardFramebuffer = ((int)1),
}

public enum ExtDiscardFramebuffer : int
{
ColorExt = ((int)0x1800),
DepthExt = ((int)0x1801),
StencilExt = ((int)0x1802),
}

public enum ExtDisjointTimerQuery : int
{
QueryCounterBitsExt = ((int)0x8864),
CurrentQueryExt = ((int)0x8865),
QueryResultExt = ((int)0x8866),
QueryResultAvailableExt = ((int)0x8867),
TimeElapsedExt = ((int)0x88BF),
TimestampExt = ((int)0x8E28),
GpuDisjointExt = ((int)0x8FBB),
}

public enum ExtDrawBuffers : int
{
MaxDrawBuffersExt = ((int)0x8824),
DrawBuffer0Ext = ((int)0x8825),
DrawBuffer1Ext = ((int)0x8826),
DrawBuffer2Ext = ((int)0x8827),
DrawBuffer3Ext = ((int)0x8828),
DrawBuffer4Ext = ((int)0x8829),
DrawBuffer5Ext = ((int)0x882A),
DrawBuffer6Ext = ((int)0x882B),
DrawBuffer7Ext = ((int)0x882C),
DrawBuffer8Ext = ((int)0x882D),
DrawBuffer9Ext = ((int)0x882E),
DrawBuffer10Ext = ((int)0x882F),
DrawBuffer11Ext = ((int)0x8830),
DrawBuffer12Ext = ((int)0x8831),
DrawBuffer13Ext = ((int)0x8832),
DrawBuffer14Ext = ((int)0x8833),
DrawBuffer15Ext = ((int)0x8834),
MaxColorAttachmentsExt = ((int)0x8CDF),
ColorAttachment0Ext = ((int)0x8CE0),
ColorAttachment1Ext = ((int)0x8CE1),
ColorAttachment2Ext = ((int)0x8CE2),
ColorAttachment3Ext = ((int)0x8CE3),
ColorAttachment4Ext = ((int)0x8CE4),
ColorAttachment5Ext = ((int)0x8CE5),
ColorAttachment6Ext = ((int)0x8CE6),
ColorAttachment7Ext = ((int)0x8CE7),
ColorAttachment8Ext = ((int)0x8CE8),
ColorAttachment9Ext = ((int)0x8CE9),
ColorAttachment10Ext = ((int)0x8CEA),
ColorAttachment11Ext = ((int)0x8CEB),
ColorAttachment12Ext = ((int)0x8CEC),
ColorAttachment13Ext = ((int)0x8CED),
ColorAttachment14Ext = ((int)0x8CEE),
ColorAttachment15Ext = ((int)0x8CEF),
}

public enum ExtDrawBuffersIndexed : int
{
Min = ((int)0x8007),
Max = ((int)0x8008),
}

public enum ExtGeometryShader : int
{
GeometryShaderBitExt = ((int)0x00000004),
LinesAdjacencyExt = ((int)0x000A),
LineStripAdjacencyExt = ((int)0x000B),
TrianglesAdjacencyExt = ((int)0x000C),
TriangleStripAdjacencyExt = ((int)0x000D),
LayerProvokingVertexExt = ((int)0x825E),
UndefinedVertexExt = ((int)0x8260),
GeometryShaderInvocationsExt = ((int)0x887F),
GeometryLinkedVerticesOutExt = ((int)0x8916),
GeometryLinkedInputTypeExt = ((int)0x8917),
GeometryLinkedOutputTypeExt = ((int)0x8918),
MaxGeometryUniformBlocksExt = ((int)0x8A2C),
MaxCombinedGeometryUniformComponentsExt = ((int)0x8A32),
MaxGeometryTextureImageUnitsExt = ((int)0x8C29),
PrimitivesGeneratedExt = ((int)0x8C87),
FramebufferAttachmentLayeredExt = ((int)0x8DA7),
FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8),
GeometryShaderExt = ((int)0x8DD9),
MaxGeometryUniformComponentsExt = ((int)0x8DDF),
MaxGeometryOutputVerticesExt = ((int)0x8DE0),
MaxGeometryTotalOutputComponentsExt = ((int)0x8DE1),
FirstVertexConventionExt = ((int)0x8E4D),
LastVertexConventionExt = ((int)0x8E4E),
MaxGeometryShaderInvocationsExt = ((int)0x8E5A),
MaxGeometryImageUniformsExt = ((int)0x90CD),
MaxGeometryShaderStorageBlocksExt = ((int)0x90D7),
MaxGeometryInputComponentsExt = ((int)0x9123),
MaxGeometryOutputComponentsExt = ((int)0x9124),
MaxGeometryAtomicCounterBuffersExt = ((int)0x92CF),
MaxGeometryAtomicCountersExt = ((int)0x92D5),
ReferencedByGeometryShaderExt = ((int)0x9309),
FramebufferDefaultLayersExt = ((int)0x9312),
MaxFramebufferLayersExt = ((int)0x9317),
}

public enum ExtInstancedArrays : int
{
VertexAttribArrayDivisorExt = ((int)0x88FE),
}

public enum ExtMapBufferRange : int
{
MapReadBitExt = ((int)0x0001),
MapWriteBitExt = ((int)0x0002),
MapInvalidateRangeBitExt = ((int)0x0004),
MapInvalidateBufferBitExt = ((int)0x0008),
MapFlushExplicitBitExt = ((int)0x0010),
MapUnsynchronizedBitExt = ((int)0x0020),
}

public enum ExtMultisampledRenderToTexture : int
{
RenderbufferSamplesExt = ((int)0x8CAB),
FramebufferIncompleteMultisampleExt = ((int)0x8D56),
MaxSamplesExt = ((int)0x8D57),
FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C),
}

public enum ExtMultiviewDrawBuffers : int
{
DrawBufferExt = ((int)0x0C01),
ReadBufferExt = ((int)0x0C02),
ColorAttachmentExt = ((int)0x90F0),
MultiviewExt = ((int)0x90F1),
MaxMultiviewBuffersExt = ((int)0x90F2),
}

public enum ExtOcclusionQueryBoolean : int
{
AnySamplesPassedExt = ((int)0x8C2F),
AnySamplesPassedConservativeExt = ((int)0x8D6A),
}

public enum ExtPrimitiveBoundingBox : int
{
PrimitiveBoundingBoxExt = ((int)0x92BE),
}

public enum ExtPvrtcSrgb : int
{
CompressedSrgbPvrtc2Bppv1Ext = ((int)0x8A54),
CompressedSrgbPvrtc4Bppv1Ext = ((int)0x8A55),
CompressedSrgbAlphaPvrtc2Bppv1Ext = ((int)0x8A56),
CompressedSrgbAlphaPvrtc4Bppv1Ext = ((int)0x8A57),
CompressedSrgbAlphaPvrtc2Bppv2Img = ((int)0x93F0),
CompressedSrgbAlphaPvrtc4Bppv2Img = ((int)0x93F1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExtreadFormatBgra : int
{
BgraExt = ((int)0x80E1),
UnsignedShort4444RevExt = ((int)0x8365),
UnsignedShort1555RevExt = ((int)0x8366),
ExtReadFormatBgra = ((int)1),
}

public enum ExtReadFormatBgra : int
{
BgraExt = ((int)0x80E1),
UnsignedShort4444RevExt = ((int)0x8365),
UnsignedShort1555RevExt = ((int)0x8366),
}

public enum ExtRobustness : int
{
LoseContextOnResetExt = ((int)0x8252),
GuiltyContextResetExt = ((int)0x8253),
InnocentContextResetExt = ((int)0x8254),
UnknownContextResetExt = ((int)0x8255),
ResetNotificationStrategyExt = ((int)0x8256),
NoResetNotificationExt = ((int)0x8261),
ContextRobustAccessExt = ((int)0x90F3),
}

public enum ExtSeparateShaderObjects : int
{
VertexShaderBitExt = ((int)0x00000001),
FragmentShaderBitExt = ((int)0x00000002),
ProgramSeparableExt = ((int)0x8258),
ActiveProgramExt = ((int)0x8259),
ProgramPipelineBindingExt = ((int)0x825A),
AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
}

public enum ExtShaderFramebufferFetch : int
{
FragmentShaderDiscardsSamplesExt = ((int)0x8A52),
}

public enum ExtShaderPixelLocalStorage : int
{
MaxShaderPixelLocalStorageFastSizeExt = ((int)0x8F63),
ShaderPixelLocalStorageExt = ((int)0x8F64),
MaxShaderPixelLocalStorageSizeExt = ((int)0x8F67),
}

public enum ExtShadowSamplers : int
{
TextureCompareModeExt = ((int)0x884C),
TextureCompareFuncExt = ((int)0x884D),
CompareRefToTextureExt = ((int)0x884E),
Sampler2DShadowExt = ((int)0x8B62),
}

public enum ExtSrgb : int
{
FramebufferAttachmentColorEncodingExt = ((int)0x8210),
SrgbExt = ((int)0x8C40),
SrgbAlphaExt = ((int)0x8C42),
Srgb8Alpha8Ext = ((int)0x8C43),
}

public enum ExtSrgbWriteControl : int
{
FramebufferSrgbExt = ((int)0x8DB9),
}

public enum ExtTessellationShader : int
{
TessControlShaderBitExt = ((int)0x00000008),
TessEvaluationShaderBitExt = ((int)0x00000010),
QuadsExt = ((int)0x0007),
PatchesExt = ((int)0x000E),
PrimitiveRestartForPatchesSupported = ((int)0x8221),
MaxTessControlInputComponentsExt = ((int)0x886C),
MaxTessEvaluationInputComponentsExt = ((int)0x886D),
MaxCombinedTessControlUniformComponentsExt = ((int)0x8E1E),
MaxCombinedTessEvaluationUniformComponentsExt = ((int)0x8E1F),
PatchVerticesExt = ((int)0x8E72),
TessControlOutputVerticesExt = ((int)0x8E75),
TessGenModeExt = ((int)0x8E76),
TessGenSpacingExt = ((int)0x8E77),
TessGenVertexOrderExt = ((int)0x8E78),
TessGenPointModeExt = ((int)0x8E79),
IsolinesExt = ((int)0x8E7A),
FractionalOddExt = ((int)0x8E7B),
FractionalEvenExt = ((int)0x8E7C),
MaxPatchVerticesExt = ((int)0x8E7D),
MaxTessGenLevelExt = ((int)0x8E7E),
MaxTessControlUniformComponentsExt = ((int)0x8E7F),
MaxTessEvaluationUniformComponentsExt = ((int)0x8E80),
MaxTessControlTextureImageUnitsExt = ((int)0x8E81),
MaxTessEvaluationTextureImageUnitsExt = ((int)0x8E82),
MaxTessControlOutputComponentsExt = ((int)0x8E83),
MaxTessPatchComponentsExt = ((int)0x8E84),
MaxTessControlTotalOutputComponentsExt = ((int)0x8E85),
MaxTessEvaluationOutputComponentsExt = ((int)0x8E86),
TessEvaluationShaderExt = ((int)0x8E87),
TessControlShaderExt = ((int)0x8E88),
MaxTessControlUniformBlocksExt = ((int)0x8E89),
MaxTessEvaluationUniformBlocksExt = ((int)0x8E8A),
MaxTessControlImageUniformsExt = ((int)0x90CB),
MaxTessEvaluationImageUniformsExt = ((int)0x90CC),
MaxTessControlShaderStorageBlocksExt = ((int)0x90D8),
MaxTessEvaluationShaderStorageBlocksExt = ((int)0x90D9),
MaxTessControlAtomicCounterBuffersExt = ((int)0x92CD),
MaxTessEvaluationAtomicCounterBuffersExt = ((int)0x92CE),
MaxTessControlAtomicCountersExt = ((int)0x92D3),
MaxTessEvaluationAtomicCountersExt = ((int)0x92D4),
IsPerPatchExt = ((int)0x92E7),
ReferencedByTessControlShaderExt = ((int)0x9307),
ReferencedByTessEvaluationShaderExt = ((int)0x9308),
}

public enum ExtTextureBorderClamp : int
{
TextureBorderColorExt = ((int)0x1004),
ClampToBorderExt = ((int)0x812D),
}

public enum ExtTextureBuffer : int
{
TextureBufferBindingExt = ((int)0x8C2A),
TextureBufferExt = ((int)0x8C2A),
MaxTextureBufferSizeExt = ((int)0x8C2B),
TextureBindingBufferExt = ((int)0x8C2C),
TextureBufferDataStoreBindingExt = ((int)0x8C2D),
SamplerBufferExt = ((int)0x8DC2),
IntSamplerBufferExt = ((int)0x8DD0),
UnsignedIntSamplerBufferExt = ((int)0x8DD8),
ImageBufferExt = ((int)0x9051),
IntImageBufferExt = ((int)0x905C),
UnsignedIntImageBufferExt = ((int)0x9067),
TextureBufferOffsetExt = ((int)0x919D),
TextureBufferSizeExt = ((int)0x919E),
TextureBufferOffsetAlignmentExt = ((int)0x919F),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExttextureCompressionDxt1 : int
{
CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
ExtTextureCompressionDxt1 = ((int)1),
}

public enum ExtTextureCompressionDxt1 : int
{
CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
}

public enum ExtTextureCompressionS3tc : int
{
CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
}

public enum ExtTextureCubeMapArray : int
{
TextureCubeMapArrayExt = ((int)0x9009),
TextureBindingCubeMapArrayExt = ((int)0x900A),
SamplerCubeMapArrayExt = ((int)0x900C),
SamplerCubeMapArrayShadowExt = ((int)0x900D),
IntSamplerCubeMapArrayExt = ((int)0x900E),
UnsignedIntSamplerCubeMapArrayExt = ((int)0x900F),
ImageCubeMapArrayExt = ((int)0x9054),
IntImageCubeMapArrayExt = ((int)0x905F),
UnsignedIntImageCubeMapArrayExt = ((int)0x906A),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExttextureFilterAnisotropic : int
{
TextureMaxAnisotropyExt = ((int)0x84FE),
MaxTextureMaxAnisotropyExt = ((int)0x84FF),
ExtTextureFilterAnisotropic = ((int)1),
}

public enum ExtTextureFilterAnisotropic : int
{
TextureMaxAnisotropyExt = ((int)0x84FE),
MaxTextureMaxAnisotropyExt = ((int)0x84FF),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExttextureFormatBgra8888 : int
{
BgraExt = ((int)0x80E1),
ExtTextureFormatBgra8888 = ((int)1),
}

public enum ExtTextureFormatBgra8888 : int
{
BgraExt = ((int)0x80E1),
}

public enum ExtTextureRg : int
{
RedExt = ((int)0x1903),
RgExt = ((int)0x8227),
R8Ext = ((int)0x8229),
Rg8Ext = ((int)0x822B),
}

public enum ExtTextureSrgbDecode : int
{
TextureSrgbDecodeExt = ((int)0x8A48),
DecodeExt = ((int)0x8A49),
SkipDecodeExt = ((int)0x8A4A),
}

public enum ExtTextureStorage : int
{
Alpha8Ext = ((int)0x803C),
Luminance8Ext = ((int)0x8040),
Luminance8Alpha8Ext = ((int)0x8045),
R32fExt = ((int)0x822E),
Rg32fExt = ((int)0x8230),
Rgba32fExt = ((int)0x8814),
Rgb32fExt = ((int)0x8815),
Alpha32fExt = ((int)0x8816),
Luminance32fExt = ((int)0x8818),
LuminanceAlpha32fExt = ((int)0x8819),
Alpha16fExt = ((int)0x881C),
Luminance16fExt = ((int)0x881E),
LuminanceAlpha16fExt = ((int)0x881F),
TextureImmutableFormatExt = ((int)0x912F),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ExttextureType2101010Rev : int
{
UnsignedInt2101010RevExt = ((int)0x8368),
ExtTextureType2101010Rev = ((int)1),
}

public enum ExtTextureType2101010Rev : int
{
UnsignedInt2101010RevExt = ((int)0x8368),
}

public enum ExtTextureView : int
{
TextureViewMinLevelExt = ((int)0x82DB),
TextureViewNumLevelsExt = ((int)0x82DC),
TextureViewMinLayerExt = ((int)0x82DD),
TextureViewNumLayersExt = ((int)0x82DE),
TextureImmutableLevels = ((int)0x82DF),
}

public enum ExtUnpackSubimage : int
{
UnpackRowLengthExt = ((int)0x0CF2),
UnpackSkipRowsExt = ((int)0x0CF3),
UnpackSkipPixelsExt = ((int)0x0CF4),
}

public enum FjshaderBinaryGccso : int
{
GccsoShaderBinaryFj = ((int)0x9260),
}

public enum FramebufferErrorCode : int
{
FramebufferComplete = ((int)0X8cd5),
FramebufferIncompleteAttachment = ((int)0X8cd6),
FramebufferIncompleteMissingAttachment = ((int)0X8cd7),
FramebufferIncompleteDimensions = ((int)0X8cd9),
FramebufferUnsupported = ((int)0X8cdd),
}

public enum FramebufferObject : int
{
None = ((int)0),
InvalidFramebufferOperation = ((int)0x0506),
StencilIndex = ((int)0x1901),
Rgba4 = ((int)0x8056),
Rgb5A1 = ((int)0x8057),
DepthComponent16 = ((int)0x81A5),
MaxRenderbufferSize = ((int)0x84E8),
FramebufferBinding = ((int)0x8CA6),
RenderbufferBinding = ((int)0x8CA7),
FramebufferAttachmentObjectType = ((int)0x8CD0),
FramebufferAttachmentObjectName = ((int)0x8CD1),
FramebufferAttachmentTextureLevel = ((int)0x8CD2),
FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3),
FramebufferComplete = ((int)0x8CD5),
FramebufferIncompleteAttachment = ((int)0x8CD6),
FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
FramebufferIncompleteDimensions = ((int)0x8CD9),
FramebufferUnsupported = ((int)0x8CDD),
ColorAttachment0 = ((int)0x8CE0),
DepthAttachment = ((int)0x8D00),
StencilAttachment = ((int)0x8D20),
Framebuffer = ((int)0x8D40),
Renderbuffer = ((int)0x8D41),
RenderbufferWidth = ((int)0x8D42),
RenderbufferHeight = ((int)0x8D43),
RenderbufferInternalFormat = ((int)0x8D44),
StencilIndex8 = ((int)0x8D48),
RenderbufferRedSize = ((int)0x8D50),
RenderbufferGreenSize = ((int)0x8D51),
RenderbufferBlueSize = ((int)0x8D52),
RenderbufferAlphaSize = ((int)0x8D53),
RenderbufferDepthSize = ((int)0x8D54),
RenderbufferStencilSize = ((int)0x8D55),
Rgb565 = ((int)0x8D62),
}

public enum FramebufferParameterName : int
{
FramebufferAttachmentObjectType = ((int)0X8cd0),
FramebufferAttachmentObjectName = ((int)0X8cd1),
FramebufferAttachmentTextureLevel = ((int)0X8cd2),
FramebufferAttachmentTextureCubeMapFace = ((int)0X8cd3),
}

public enum FramebufferSlot : int
{
ColorAttachment0 = ((int)0X8ce0),
DepthAttachment = ((int)0X8d00),
StencilAttachment = ((int)0X8d20),
}

public enum FramebufferTarget : int
{
Framebuffer = ((int)0X8d40),
}

public enum FrontFaceDirection : int
{
Cw = ((int)0x0900),
Ccw = ((int)0x0901),
}

public enum GetPName : int
{
LineWidth = ((int)0x0B21),
CullFace = ((int)0X0b44),
CullFaceMode = ((int)0x0B45),
FrontFace = ((int)0x0B46),
DepthRange = ((int)0x0B70),
DepthTest = ((int)0X0b71),
DepthWritemask = ((int)0x0B72),
DepthClearValue = ((int)0x0B73),
DepthFunc = ((int)0x0B74),
StencilTest = ((int)0X0b90),
StencilClearValue = ((int)0x0B91),
StencilFunc = ((int)0x0B92),
StencilValueMask = ((int)0x0B93),
StencilFail = ((int)0x0B94),
StencilPassDepthFail = ((int)0x0B95),
StencilPassDepthPass = ((int)0x0B96),
StencilRef = ((int)0x0B97),
StencilWritemask = ((int)0x0B98),
Viewport = ((int)0x0BA2),
Dither = ((int)0X0bd0),
Blend = ((int)0X0be2),
ScissorBox = ((int)0x0C10),
ScissorTest = ((int)0X0c11),
ColorClearValue = ((int)0x0C22),
ColorWritemask = ((int)0x0C23),
UnpackAlignment = ((int)0x0CF5),
PackAlignment = ((int)0x0D05),
MaxTextureSize = ((int)0x0D33),
MaxViewportDims = ((int)0x0D3A),
SubpixelBits = ((int)0x0D50),
RedBits = ((int)0x0D52),
GreenBits = ((int)0x0D53),
BlueBits = ((int)0x0D54),
AlphaBits = ((int)0x0D55),
DepthBits = ((int)0x0D56),
StencilBits = ((int)0x0D57),
Texture2D = ((int)0X0de1),
PolygonOffsetUnits = ((int)0x2A00),
BlendColor = ((int)0X8005),
BlendEquation = ((int)0X8009),
BlendEquationRgb = ((int)0X8009),
PolygonOffsetFill = ((int)0X8037),
PolygonOffsetFactor = ((int)0x8038),
TextureBinding2D = ((int)0x8069),
SampleAlphaToCoverage = ((int)0X809e),
SampleCoverage = ((int)0X80a0),
SampleBuffers = ((int)0x80A8),
Samples = ((int)0x80A9),
SampleCoverageValue = ((int)0x80AA),
SampleCoverageInvert = ((int)0x80AB),
BlendDstRgb = ((int)0X80c8),
BlendSrcRgb = ((int)0X80c9),
BlendDstAlpha = ((int)0X80ca),
BlendSrcAlpha = ((int)0X80cb),
GenerateMipmapHint = ((int)0X8192),
AliasedPointSizeRange = ((int)0x846D),
AliasedLineWidthRange = ((int)0x846E),
ActiveTexture = ((int)0X84e0),
MaxRenderbufferSize = ((int)0X84e8),
TextureBindingCubeMap = ((int)0X8514),
MaxCubeMapTextureSize = ((int)0X851c),
NumCompressedTextureFormats = ((int)0X86a2),
CompressedTextureFormats = ((int)0X86a3),
StencilBackFunc = ((int)0x8800),
StencilBackFail = ((int)0x8801),
StencilBackPassDepthFail = ((int)0x8802),
StencilBackPassDepthPass = ((int)0x8803),
BlendEquationAlpha = ((int)0X883d),
MaxVertexAttribs = ((int)0X8869),
MaxTextureImageUnits = ((int)0X8872),
ArrayBufferBinding = ((int)0X8894),
ElementArrayBufferBinding = ((int)0X8895),
MaxVertexTextureImageUnits = ((int)0X8b4c),
MaxCombinedTextureImageUnits = ((int)0X8b4d),
CurrentProgram = ((int)0X8b8d),
ImplementationColorReadType = ((int)0X8b9a),
ImplementationColorReadFormat = ((int)0X8b9b),
StencilBackRef = ((int)0x8CA3),
StencilBackValueMask = ((int)0x8CA4),
StencilBackWritemask = ((int)0x8CA5),
FramebufferBinding = ((int)0X8ca6),
RenderbufferBinding = ((int)0X8ca7),
ShaderBinaryFormats = ((int)0X8df8),
NumShaderBinaryFormats = ((int)0X8df9),
ShaderCompiler = ((int)0X8dfa),
MaxVertexUniformVectors = ((int)0X8dfb),
MaxVaryingVectors = ((int)0X8dfc),
MaxFragmentUniformVectors = ((int)0X8dfd),
}

public enum GetTextureParameter : int
{
TextureMagFilter = ((int)0X2800),
TextureMinFilter = ((int)0X2801),
TextureWrapS = ((int)0X2802),
TextureWrapT = ((int)0X2803),
NumCompressedTextureFormats = ((int)0x86A2),
CompressedTextureFormats = ((int)0x86A3),
}

public enum HintMode : int
{
DontCare = ((int)0x1100),
Fastest = ((int)0x1101),
Nicest = ((int)0x1102),
}

public enum HintTarget : int
{
GenerateMipmapHint = ((int)0x8192),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ImgmultisampledRenderToTexture : int
{
RenderbufferSamplesImg = ((int)0x9133),
FramebufferIncompleteMultisampleImg = ((int)0x9134),
MaxSamplesImg = ((int)0x9135),
TextureSamplesImg = ((int)0x9136),
ImgMultisampledRenderToTexture = ((int)1),
}

public enum ImgMultisampledRenderToTexture : int
{
RenderbufferSamplesImg = ((int)0x9133),
FramebufferIncompleteMultisampleImg = ((int)0x9134),
MaxSamplesImg = ((int)0x9135),
TextureSamplesImg = ((int)0x9136),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ImgprogramBinary : int
{
SgxProgramBinaryImg = ((int)0x9130),
ImgProgramBinary = ((int)1),
}

public enum ImgProgramBinary : int
{
SgxProgramBinaryImg = ((int)0x9130),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ImgreadFormat : int
{
BgraImg = ((int)0x80E1),
UnsignedShort4444RevImg = ((int)0x8365),
ImgReadFormat = ((int)1),
}

public enum ImgReadFormat : int
{
BgraImg = ((int)0x80E1),
UnsignedShort4444RevImg = ((int)0x8365),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ImgshaderBinary : int
{
SgxBinaryImg = ((int)0x8C0A),
ImgShaderBinary = ((int)1),
}

public enum ImgShaderBinary : int
{
SgxBinaryImg = ((int)0x8C0A),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum ImgtextureCompressionPvrtc : int
{
CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
ImgTextureCompressionPvrtc = ((int)1),
}

public enum ImgTextureCompressionPvrtc : int
{
CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00),
CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01),
CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02),
CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03),
}

public enum ImgTextureCompressionPvrtc2 : int
{
CompressedRgbaPvrtc2Bppv2Img = ((int)0x9137),
CompressedRgbaPvrtc4Bppv2Img = ((int)0x9138),
}

public enum IntelPerformanceQuery : int
{
PerfquerySingleContextIntel = ((int)0x00000000),
PerfqueryGlobalContextIntel = ((int)0x00000001),
PerfqueryDonotFlushIntel = ((int)0x83F9),
PerfqueryFlushIntel = ((int)0x83FA),
PerfqueryWaitIntel = ((int)0x83FB),
PerfqueryCounterEventIntel = ((int)0x94F0),
PerfqueryCounterDurationNormIntel = ((int)0x94F1),
PerfqueryCounterDurationRawIntel = ((int)0x94F2),
PerfqueryCounterThroughputIntel = ((int)0x94F3),
PerfqueryCounterRawIntel = ((int)0x94F4),
PerfqueryCounterTimestampIntel = ((int)0x94F5),
PerfqueryCounterDataUint32Intel = ((int)0x94F8),
PerfqueryCounterDataUint64Intel = ((int)0x94F9),
PerfqueryCounterDataFloatIntel = ((int)0x94FA),
PerfqueryCounterDataDoubleIntel = ((int)0x94FB),
PerfqueryCounterDataBool32Intel = ((int)0x94FC),
PerfqueryQueryNameLengthMaxIntel = ((int)0x94FD),
PerfqueryCounterNameLengthMaxIntel = ((int)0x94FE),
PerfqueryCounterDescLengthMaxIntel = ((int)0x94FF),
PerfqueryGpaExtendedCountersIntel = ((int)0x9500),
}

public enum KhrblendEquationAdvanced : int
{
BlendAdvancedCoherentKhr = ((int)0x9285),
MultiplyKhr = ((int)0x9294),
ScreenKhr = ((int)0x9295),
OverlayKhr = ((int)0x9296),
DarkenKhr = ((int)0x9297),
LightenKhr = ((int)0x9298),
ColordodgeKhr = ((int)0x9299),
ColorburnKhr = ((int)0x929A),
HardlightKhr = ((int)0x929B),
SoftlightKhr = ((int)0x929C),
DifferenceKhr = ((int)0x929E),
ExclusionKhr = ((int)0x92A0),
HslHueKhr = ((int)0x92AD),
HslSaturationKhr = ((int)0x92AE),
HslColorKhr = ((int)0x92AF),
HslLuminosityKhr = ((int)0x92B0),
}

public enum Khrdebug : int
{
ContextFlagDebugBitKhr = ((int)0x00000002),
StackOverflowKhr = ((int)0x0503),
StackUnderflowKhr = ((int)0x0504),
VertexArrayKhr = ((int)0x8074),
DebugOutputSynchronousKhr = ((int)0x8242),
DebugNextLoggedMessageLengthKhr = ((int)0x8243),
DebugCallbackFunctionKhr = ((int)0x8244),
DebugCallbackUserParamKhr = ((int)0x8245),
DebugSourceApiKhr = ((int)0x8246),
DebugSourceWindowSystemKhr = ((int)0x8247),
DebugSourceShaderCompilerKhr = ((int)0x8248),
DebugSourceThirdPartyKhr = ((int)0x8249),
DebugSourceApplicationKhr = ((int)0x824A),
DebugSourceOtherKhr = ((int)0x824B),
DebugTypeErrorKhr = ((int)0x824C),
DebugTypeDeprecatedBehaviorKhr = ((int)0x824D),
DebugTypeUndefinedBehaviorKhr = ((int)0x824E),
DebugTypePortabilityKhr = ((int)0x824F),
DebugTypePerformanceKhr = ((int)0x8250),
DebugTypeOtherKhr = ((int)0x8251),
DebugTypeMarkerKhr = ((int)0x8268),
DebugTypePushGroupKhr = ((int)0x8269),
DebugTypePopGroupKhr = ((int)0x826A),
DebugSeverityNotificationKhr = ((int)0x826B),
MaxDebugGroupStackDepthKhr = ((int)0x826C),
DebugGroupStackDepthKhr = ((int)0x826D),
BufferKhr = ((int)0x82E0),
ShaderKhr = ((int)0x82E1),
ProgramKhr = ((int)0x82E2),
QueryKhr = ((int)0x82E3),
Sampler = ((int)0x82E6),
SamplerKhr = ((int)0x82E6),
MaxLabelLengthKhr = ((int)0x82E8),
MaxDebugMessageLengthKhr = ((int)0x9143),
MaxDebugLoggedMessagesKhr = ((int)0x9144),
DebugLoggedMessagesKhr = ((int)0x9145),
DebugSeverityHighKhr = ((int)0x9146),
DebugSeverityMediumKhr = ((int)0x9147),
DebugSeverityLowKhr = ((int)0x9148),
DebugOutputKhr = ((int)0x92E0),
}

public enum KhrtextureCompressionAstcHdr : int
{
CompressedRgbaAstc4X4Khr = ((int)0x93B0),
CompressedRgbaAstc5X4Khr = ((int)0x93B1),
CompressedRgbaAstc5X5Khr = ((int)0x93B2),
CompressedRgbaAstc6X5Khr = ((int)0x93B3),
CompressedRgbaAstc6X6Khr = ((int)0x93B4),
CompressedRgbaAstc8X5Khr = ((int)0x93B5),
CompressedRgbaAstc8X6Khr = ((int)0x93B6),
CompressedRgbaAstc8X8Khr = ((int)0x93B7),
CompressedRgbaAstc10X5Khr = ((int)0x93B8),
CompressedRgbaAstc10X6Khr = ((int)0x93B9),
CompressedRgbaAstc10X8Khr = ((int)0x93BA),
CompressedRgbaAstc10X10Khr = ((int)0x93BB),
CompressedRgbaAstc12X10Khr = ((int)0x93BC),
CompressedRgbaAstc12X12Khr = ((int)0x93BD),
CompressedSrgb8Alpha8Astc4X4Khr = ((int)0x93D0),
CompressedSrgb8Alpha8Astc5X4Khr = ((int)0x93D1),
CompressedSrgb8Alpha8Astc5X5Khr = ((int)0x93D2),
CompressedSrgb8Alpha8Astc6X5Khr = ((int)0x93D3),
CompressedSrgb8Alpha8Astc6X6Khr = ((int)0x93D4),
CompressedSrgb8Alpha8Astc8X5Khr = ((int)0x93D5),
CompressedSrgb8Alpha8Astc8X6Khr = ((int)0x93D6),
CompressedSrgb8Alpha8Astc8X8Khr = ((int)0x93D7),
CompressedSrgb8Alpha8Astc10X5Khr = ((int)0x93D8),
CompressedSrgb8Alpha8Astc10X6Khr = ((int)0x93D9),
CompressedSrgb8Alpha8Astc10X8Khr = ((int)0x93DA),
CompressedSrgb8Alpha8Astc10X10Khr = ((int)0x93DB),
CompressedSrgb8Alpha8Astc12X10Khr = ((int)0x93DC),
CompressedSrgb8Alpha8Astc12X12Khr = ((int)0x93DD),
}

public enum NvBlendEquationAdvanced : int
{
XorNv = ((int)0x1506),
RedNv = ((int)0x1903),
GreenNv = ((int)0x1904),
BlueNv = ((int)0x1905),
BlendPremultipliedSrcNv = ((int)0x9280),
BlendOverlapNv = ((int)0x9281),
UncorrelatedNv = ((int)0x9282),
DisjointNv = ((int)0x9283),
ConjointNv = ((int)0x9284),
SrcNv = ((int)0x9286),
DstNv = ((int)0x9287),
SrcOverNv = ((int)0x9288),
DstOverNv = ((int)0x9289),
SrcInNv = ((int)0x928A),
DstInNv = ((int)0x928B),
SrcOutNv = ((int)0x928C),
DstOutNv = ((int)0x928D),
SrcAtopNv = ((int)0x928E),
DstAtopNv = ((int)0x928F),
PlusNv = ((int)0x9291),
PlusDarkerNv = ((int)0x9292),
MultiplyNv = ((int)0x9294),
ScreenNv = ((int)0x9295),
OverlayNv = ((int)0x9296),
DarkenNv = ((int)0x9297),
LightenNv = ((int)0x9298),
ColordodgeNv = ((int)0x9299),
ColorburnNv = ((int)0x929A),
HardlightNv = ((int)0x929B),
SoftlightNv = ((int)0x929C),
DifferenceNv = ((int)0x929E),
MinusNv = ((int)0x929F),
ExclusionNv = ((int)0x92A0),
ContrastNv = ((int)0x92A1),
InvertRgbNv = ((int)0x92A3),
LineardodgeNv = ((int)0x92A4),
LinearburnNv = ((int)0x92A5),
VividlightNv = ((int)0x92A6),
LinearlightNv = ((int)0x92A7),
PinlightNv = ((int)0x92A8),
HardmixNv = ((int)0x92A9),
HslHueNv = ((int)0x92AD),
HslSaturationNv = ((int)0x92AE),
HslColorNv = ((int)0x92AF),
HslLuminosityNv = ((int)0x92B0),
PlusClampedNv = ((int)0x92B1),
PlusClampedAlphaNv = ((int)0x92B2),
MinusClampedNv = ((int)0x92B3),
InvertOvgNv = ((int)0x92B4),
}

public enum NvBlendEquationAdvancedCoherent : int
{
BlendAdvancedCoherentNv = ((int)0x9285),
}

public enum NvCopyBuffer : int
{
CopyReadBufferNv = ((int)0x8F36),
CopyWriteBufferNv = ((int)0x8F37),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum NvcoverageSample : int
{
CoverageBufferBitNv = ((int)0x8000),
CoverageComponentNv = ((int)0x8ED0),
CoverageComponent4Nv = ((int)0x8ED1),
CoverageAttachmentNv = ((int)0x8ED2),
CoverageBuffersNv = ((int)0x8ED3),
CoverageSamplesNv = ((int)0x8ED4),
CoverageAllFragmentsNv = ((int)0x8ED5),
CoverageEdgeFragmentsNv = ((int)0x8ED6),
CoverageAutomaticNv = ((int)0x8ED7),
NvCoverageSample = ((int)1),
}

public enum NvCoverageSample : int
{
CoverageBufferBitNv = ((int)0x00008000),
CoverageComponentNv = ((int)0x8ED0),
CoverageComponent4Nv = ((int)0x8ED1),
CoverageAttachmentNv = ((int)0x8ED2),
CoverageBuffersNv = ((int)0x8ED3),
CoverageSamplesNv = ((int)0x8ED4),
CoverageAllFragmentsNv = ((int)0x8ED5),
CoverageEdgeFragmentsNv = ((int)0x8ED6),
CoverageAutomaticNv = ((int)0x8ED7),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum NvdepthNonlinear : int
{
DepthComponent16NonlinearNv = ((int)0x8E2C),
NvDepthNonlinear = ((int)1),
}

public enum NvDepthNonlinear : int
{
DepthComponent16NonlinearNv = ((int)0x8E2C),
}

public enum NvDrawBuffers : int
{
MaxDrawBuffersNv = ((int)0x8824),
DrawBuffer0Nv = ((int)0x8825),
DrawBuffer1Nv = ((int)0x8826),
DrawBuffer2Nv = ((int)0x8827),
DrawBuffer3Nv = ((int)0x8828),
DrawBuffer4Nv = ((int)0x8829),
DrawBuffer5Nv = ((int)0x882A),
DrawBuffer6Nv = ((int)0x882B),
DrawBuffer7Nv = ((int)0x882C),
DrawBuffer8Nv = ((int)0x882D),
DrawBuffer9Nv = ((int)0x882E),
DrawBuffer10Nv = ((int)0x882F),
DrawBuffer11Nv = ((int)0x8830),
DrawBuffer12Nv = ((int)0x8831),
DrawBuffer13Nv = ((int)0x8832),
DrawBuffer14Nv = ((int)0x8833),
DrawBuffer15Nv = ((int)0x8834),
ColorAttachment0Nv = ((int)0x8CE0),
ColorAttachment1Nv = ((int)0x8CE1),
ColorAttachment2Nv = ((int)0x8CE2),
ColorAttachment3Nv = ((int)0x8CE3),
ColorAttachment4Nv = ((int)0x8CE4),
ColorAttachment5Nv = ((int)0x8CE5),
ColorAttachment6Nv = ((int)0x8CE6),
ColorAttachment7Nv = ((int)0x8CE7),
ColorAttachment8Nv = ((int)0x8CE8),
ColorAttachment9Nv = ((int)0x8CE9),
ColorAttachment10Nv = ((int)0x8CEA),
ColorAttachment11Nv = ((int)0x8CEB),
ColorAttachment12Nv = ((int)0x8CEC),
ColorAttachment13Nv = ((int)0x8CED),
ColorAttachment14Nv = ((int)0x8CEE),
ColorAttachment15Nv = ((int)0x8CEF),
}

public enum NvFboColorAttachments : int
{
MaxColorAttachmentsNv = ((int)0x8CDF),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Nvfence : int
{
AllCompletedNv = ((int)0x84F2),
FenceStatusNv = ((int)0x84F3),
FenceConditionNv = ((int)0x84F4),
NvFence = ((int)1),
}

public enum NvFence : int
{
AllCompletedNv = ((int)0x84F2),
FenceStatusNv = ((int)0x84F3),
FenceConditionNv = ((int)0x84F4),
}

public enum NvFramebufferBlit : int
{
DrawFramebufferBindingNv = ((int)0x8CA6),
ReadFramebufferNv = ((int)0x8CA8),
DrawFramebufferNv = ((int)0x8CA9),
ReadFramebufferBindingNv = ((int)0x8CAA),
}

public enum NvFramebufferMultisample : int
{
RenderbufferSamplesNv = ((int)0x8CAB),
FramebufferIncompleteMultisampleNv = ((int)0x8D56),
MaxSamplesNv = ((int)0x8D57),
}

public enum NvInstancedArrays : int
{
VertexAttribArrayDivisorNv = ((int)0x88FE),
}

public enum NvNonSquareMatrices : int
{
FloatMat2x3Nv = ((int)0x8B65),
FloatMat2x4Nv = ((int)0x8B66),
FloatMat3x2Nv = ((int)0x8B67),
FloatMat3x4Nv = ((int)0x8B68),
FloatMat4x2Nv = ((int)0x8B69),
FloatMat4x3Nv = ((int)0x8B6A),
}

public enum NvReadBuffer : int
{
ReadBufferNv = ((int)0x0C02),
}

public enum NvShadowSamplersArray : int
{
Sampler2DArrayShadowNv = ((int)0x8DC4),
}

public enum NvShadowSamplersCube : int
{
SamplerCubeShadowNv = ((int)0x8DC5),
}

public enum NvSrgbFormats : int
{
Etc1Srgb8Nv = ((int)0x88EE),
Srgb8Nv = ((int)0x8C41),
SluminanceAlphaNv = ((int)0x8C44),
Sluminance8Alpha8Nv = ((int)0x8C45),
SluminanceNv = ((int)0x8C46),
Sluminance8Nv = ((int)0x8C47),
CompressedSrgbS3tcDxt1Nv = ((int)0x8C4C),
CompressedSrgbAlphaS3tcDxt1Nv = ((int)0x8C4D),
CompressedSrgbAlphaS3tcDxt3Nv = ((int)0x8C4E),
CompressedSrgbAlphaS3tcDxt5Nv = ((int)0x8C4F),
}

public enum NvTextureBorderClamp : int
{
TextureBorderColorNv = ((int)0x1004),
ClampToBorderNv = ((int)0x812D),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OescompressedEtc1Rgb8Texture : int
{
Etc1Rgb8Oes = ((int)0x8D64),
OesCompressedEtc1Rgb8Texture = ((int)1),
}

public enum OesCompressedEtc1Rgb8Texture : int
{
Etc1Rgb8Oes = ((int)0x8D64),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OescompressedPalettedTexture : int
{
Palette4Rgb8Oes = ((int)0x8B90),
Palette4Rgba8Oes = ((int)0x8B91),
Palette4R5G6B5Oes = ((int)0x8B92),
Palette4Rgba4Oes = ((int)0x8B93),
Palette4Rgb5A1Oes = ((int)0x8B94),
Palette8Rgb8Oes = ((int)0x8B95),
Palette8Rgba8Oes = ((int)0x8B96),
Palette8R5G6B5Oes = ((int)0x8B97),
Palette8Rgba4Oes = ((int)0x8B98),
Palette8Rgb5A1Oes = ((int)0x8B99),
OesCompressedPalettedTexture = ((int)1),
}

public enum OesCompressedPalettedTexture : int
{
Palette4Rgb8Oes = ((int)0x8B90),
Palette4Rgba8Oes = ((int)0x8B91),
Palette4R5G6B5Oes = ((int)0x8B92),
Palette4Rgba4Oes = ((int)0x8B93),
Palette4Rgb5A1Oes = ((int)0x8B94),
Palette8Rgb8Oes = ((int)0x8B95),
Palette8Rgba8Oes = ((int)0x8B96),
Palette8R5G6B5Oes = ((int)0x8B97),
Palette8Rgba4Oes = ((int)0x8B98),
Palette8Rgb5A1Oes = ((int)0x8B99),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oesdepth24 : int
{
DepthComponent24Oes = ((int)0x81A6),
OesDepth24 = ((int)1),
}

public enum OesDepth24 : int
{
DepthComponent24Oes = ((int)0x81A6),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oesdepth32 : int
{
DepthComponent32Oes = ((int)0x81A7),
OesDepth32 = ((int)1),
}

public enum OesDepth32 : int
{
DepthComponent32Oes = ((int)0x81A7),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesdepthTexture : int
{
OesDepthTexture = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oeseglimage : int
{
OesEglImage = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OeseglimageExternal : int
{
TextureExternalOes = ((int)0x8D65),
SamplerExternalOes = ((int)0x8D66),
TextureBindingExternalOes = ((int)0x8D67),
RequiredTextureImageUnitsOes = ((int)0x8D68),
OesEglImageExternal = ((int)1),
}

public enum OesEglImageExternal : int
{
TextureExternalOes = ((int)0x8D65),
SamplerExternalOes = ((int)0x8D66),
TextureBindingExternalOes = ((int)0x8D67),
RequiredTextureImageUnitsOes = ((int)0x8D68),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OeselementIndexUint : int
{
UnsignedInt = ((int)0x1405),
OesElementIndexUint = ((int)1),
}

public enum OesElementIndexUint : int
{
UnsignedInt = ((int)0x1405),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesfboRenderMipmap : int
{
OesFboRenderMipmap = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesfragmentPrecisionHigh : int
{
OesFragmentPrecisionHigh = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesgetProgramBinary : int
{
ProgramBinaryLengthOes = ((int)0x8741),
NumProgramBinaryFormatsOes = ((int)0x87FE),
ProgramBinaryFormatsOes = ((int)0x87FF),
OesGetProgramBinary = ((int)1),
}

public enum OesGetProgramBinary : int
{
ProgramBinaryLengthOes = ((int)0x8741),
NumProgramBinaryFormatsOes = ((int)0x87FE),
ProgramBinaryFormatsOes = ((int)0x87FF),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oesmapbuffer : int
{
WriteOnlyOes = ((int)0x88B9),
BufferAccessOes = ((int)0x88BB),
BufferMappedOes = ((int)0x88BC),
BufferMapPointerOes = ((int)0x88BD),
OesMapbuffer = ((int)1),
}

public enum OesMapbuffer : int
{
WriteOnlyOes = ((int)0x88B9),
BufferAccessOes = ((int)0x88BB),
BufferMappedOes = ((int)0x88BC),
BufferMapPointerOes = ((int)0x88BD),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OespackedDepthStencil : int
{
DepthStencilOes = ((int)0x84F9),
UnsignedInt248Oes = ((int)0x84FA),
Depth24Stencil8Oes = ((int)0x88F0),
OesPackedDepthStencil = ((int)1),
}

public enum OesPackedDepthStencil : int
{
DepthStencilOes = ((int)0x84F9),
UnsignedInt248Oes = ((int)0x84FA),
Depth24Stencil8Oes = ((int)0x88F0),
}

public enum OesRequiredInternalformat : int
{
Alpha8Oes = ((int)0x803C),
Luminance8Oes = ((int)0x8040),
Luminance4Alpha4Oes = ((int)0x8043),
Luminance8Alpha8Oes = ((int)0x8045),
Rgb8Oes = ((int)0x8051),
Rgb10Ext = ((int)0x8052),
Rgba4Oes = ((int)0x8056),
Rgb5A1Oes = ((int)0x8057),
Rgba8Oes = ((int)0x8058),
Rgb10A2Ext = ((int)0x8059),
DepthComponent16Oes = ((int)0x81A5),
Rgb565Oes = ((int)0x8D62),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oesrgb8Rgba8 : int
{
Rgb8Oes = ((int)0x8051),
Rgba8Oes = ((int)0x8058),
OesRgb8Rgba8 = ((int)1),
}

public enum OesRgb8Rgba8 : int
{
Rgb8Oes = ((int)0x8051),
Rgba8Oes = ((int)0x8058),
}

public enum OesSampleShading : int
{
SampleShadingOes = ((int)0x8C36),
MinSampleShadingValueOes = ((int)0x8C37),
}

public enum OesShaderMultisampleInterpolation : int
{
MinFragmentInterpolationOffsetOes = ((int)0x8E5B),
MaxFragmentInterpolationOffsetOes = ((int)0x8E5C),
FragmentInterpolationOffsetBitsOes = ((int)0x8E5D),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesstandardDerivatives : int
{
FragmentShaderDerivativeHintOes = ((int)0x8B8B),
OesStandardDerivatives = ((int)1),
}

public enum OesStandardDerivatives : int
{
FragmentShaderDerivativeHintOes = ((int)0x8B8B),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oesstencil1 : int
{
StencilIndex1Oes = ((int)0x8D46),
OesStencil1 = ((int)1),
}

public enum OesStencil1 : int
{
StencilIndex1Oes = ((int)0x8D46),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oesstencil4 : int
{
StencilIndex4Oes = ((int)0x8D47),
OesStencil4 = ((int)1),
}

public enum OesStencil4 : int
{
StencilIndex4Oes = ((int)0x8D47),
}

public enum OesSurfacelessContext : int
{
FramebufferUndefinedOes = ((int)0x8219),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum Oestexture3D : int
{
TextureBinding3DOes = ((int)0x806A),
Texture3DOes = ((int)0x806F),
TextureWrapROes = ((int)0x8072),
Max3DTextureSizeOes = ((int)0x8073),
Sampler3DOes = ((int)0x8B5F),
FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4),
OesTexture3D = ((int)1),
}

public enum OesTexture3D : int
{
TextureBinding3DOes = ((int)0x806A),
Texture3DOes = ((int)0x806F),
TextureWrapROes = ((int)0x8072),
Max3DTextureSizeOes = ((int)0x8073),
Sampler3DOes = ((int)0x8B5F),
FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4),
}

public enum OesTextureCompressionAstc : int
{
CompressedRgbaAstc3X3x3Oes = ((int)0x93C0),
CompressedRgbaAstc4X3x3Oes = ((int)0x93C1),
CompressedRgbaAstc4X4x3Oes = ((int)0x93C2),
CompressedRgbaAstc4X4x4Oes = ((int)0x93C3),
CompressedRgbaAstc5X4x4Oes = ((int)0x93C4),
CompressedRgbaAstc5X5x4Oes = ((int)0x93C5),
CompressedRgbaAstc5X5x5Oes = ((int)0x93C6),
CompressedRgbaAstc6X5x5Oes = ((int)0x93C7),
CompressedRgbaAstc6X6x5Oes = ((int)0x93C8),
CompressedRgbaAstc6X6x6Oes = ((int)0x93C9),
CompressedSrgb8Alpha8Astc3X3x3Oes = ((int)0x93E0),
CompressedSrgb8Alpha8Astc4X3x3Oes = ((int)0x93E1),
CompressedSrgb8Alpha8Astc4X4x3Oes = ((int)0x93E2),
CompressedSrgb8Alpha8Astc4X4x4Oes = ((int)0x93E3),
CompressedSrgb8Alpha8Astc5X4x4Oes = ((int)0x93E4),
CompressedSrgb8Alpha8Astc5X5x4Oes = ((int)0x93E5),
CompressedSrgb8Alpha8Astc5X5x5Oes = ((int)0x93E6),
CompressedSrgb8Alpha8Astc6X5x5Oes = ((int)0x93E7),
CompressedSrgb8Alpha8Astc6X6x5Oes = ((int)0x93E8),
CompressedSrgb8Alpha8Astc6X6x6Oes = ((int)0x93E9),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OestextureFloat : int
{
OesTextureFloat = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OestextureFloatLinear : int
{
OesTextureFloatLinear = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OestextureHalfFloat : int
{
HalfFloatOes = ((int)0x8D61),
OesTextureHalfFloat = ((int)1),
}

public enum OesTextureHalfFloat : int
{
HalfFloatOes = ((int)0x8D61),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OestextureHalfFloatLinear : int
{
OesTextureHalfFloatLinear = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OestextureNpot : int
{
OesTextureNpot = ((int)1),
}

public enum OesTextureStencil8 : int
{
StencilIndexOes = ((int)0x1901),
StencilIndex8Oes = ((int)0x8D48),
}

public enum OesTextureStorageMultisample2dArray : int
{
Texture2DMultisampleArrayOes = ((int)0x9102),
TextureBinding2DMultisampleArrayOes = ((int)0x9105),
Sampler2DMultisampleArrayOes = ((int)0x910B),
IntSampler2DMultisampleArrayOes = ((int)0x910C),
UnsignedIntSampler2DMultisampleArrayOes = ((int)0x910D),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesvertexArrayObject : int
{
VertexArrayBindingOes = ((int)0x85B5),
OesVertexArrayObject = ((int)1),
}

public enum OesVertexArrayObject : int
{
VertexArrayBindingOes = ((int)0x85B5),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesvertexHalfFloat : int
{
OesVertexHalfFloat = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OesvertexType1010102 : int
{
UnsignedInt1010102Oes = ((int)0x8DF6),
Int1010102Oes = ((int)0x8DF7),
OesVertexType1010102 = ((int)1),
}

public enum OesVertexType1010102 : int
{
UnsignedInt1010102Oes = ((int)0x8DF6),
Int1010102Oes = ((int)0x8DF7),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum OpenGlescoreVersions : int
{
EsVersion20 = ((int)1),
}

public enum OpenGlEsCoreVersions : int
{
EsVersion20 = ((int)1),
}

public enum PixelFormat : int
{
DepthComponent = ((int)0x1902),
Alpha = ((int)0x1906),
Rgb = ((int)0x1907),
Rgba = ((int)0x1908),
Luminance = ((int)0x1909),
LuminanceAlpha = ((int)0x190A),
}

public enum PixelInternalFormat : int
{
Alpha = ((int)0X1906),
Rgb = ((int)0X1907),
Rgba = ((int)0X1908),
Luminance = ((int)0X1909),
LuminanceAlpha = ((int)0X190a),
}

public enum PixelStoreParameter : int
{
UnpackAlignment = ((int)0X0cf5),
PackAlignment = ((int)0X0d05),
}

public enum PixelType : int
{
UnsignedByte = ((int)0X1401),
UnsignedShort4444 = ((int)0x8033),
UnsignedShort5551 = ((int)0x8034),
UnsignedShort565 = ((int)0x8363),
}

public enum ProgramParameter : int
{
DeleteStatus = ((int)0X8b80),
LinkStatus = ((int)0X8b82),
ValidateStatus = ((int)0X8b83),
InfoLogLength = ((int)0X8b84),
AttachedShaders = ((int)0X8b85),
ActiveUniforms = ((int)0X8b86),
ActiveUniformMaxLength = ((int)0X8b87),
ActiveAttributes = ((int)0X8b89),
ActiveAttributeMaxLength = ((int)0X8b8a),
}

public enum QcomAlphaTest : int
{
AlphaTestQcom = ((int)0x0BC0),
AlphaTestFuncQcom = ((int)0x0BC1),
AlphaTestRefQcom = ((int)0x0BC2),
}

public enum QcomBinningControl : int
{
BinningControlHintQcom = ((int)0x8FB0),
CpuOptimizedQcom = ((int)0x8FB1),
GpuOptimizedQcom = ((int)0x8FB2),
RenderDirectToFramebufferQcom = ((int)0x8FB3),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum QcomdriverControl : int
{
QcomDriverControl = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum QcomextendedGet : int
{
TextureWidthQcom = ((int)0x8BD2),
TextureHeightQcom = ((int)0x8BD3),
TextureDepthQcom = ((int)0x8BD4),
TextureInternalFormatQcom = ((int)0x8BD5),
TextureFormatQcom = ((int)0x8BD6),
TextureTypeQcom = ((int)0x8BD7),
TextureImageValidQcom = ((int)0x8BD8),
TextureNumLevelsQcom = ((int)0x8BD9),
TextureTargetQcom = ((int)0x8BDA),
TextureObjectValidQcom = ((int)0x8BDB),
StateRestore = ((int)0x8BDC),
QcomExtendedGet = ((int)1),
}

public enum QcomExtendedGet : int
{
TextureWidthQcom = ((int)0x8BD2),
TextureHeightQcom = ((int)0x8BD3),
TextureDepthQcom = ((int)0x8BD4),
TextureInternalFormatQcom = ((int)0x8BD5),
TextureFormatQcom = ((int)0x8BD6),
TextureTypeQcom = ((int)0x8BD7),
TextureImageValidQcom = ((int)0x8BD8),
TextureNumLevelsQcom = ((int)0x8BD9),
TextureTargetQcom = ((int)0x8BDA),
TextureObjectValidQcom = ((int)0x8BDB),
StateRestore = ((int)0x8BDC),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum QcomextendedGet2 : int
{
QcomExtendedGet2 = ((int)1),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum QcomperfmonGlobalMode : int
{
PerfmonGlobalModeQcom = ((int)0x8FA0),
QcomPerfmonGlobalMode = ((int)1),
}

public enum QcomPerfmonGlobalMode : int
{
PerfmonGlobalModeQcom = ((int)0x8FA0),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum QcomtiledRendering : int
{
ColorBufferBit0Qcom = ((int)0x00000001),
ColorBufferBit1Qcom = ((int)0x00000002),
ColorBufferBit2Qcom = ((int)0x00000004),
ColorBufferBit3Qcom = ((int)0x00000008),
ColorBufferBit4Qcom = ((int)0x00000010),
ColorBufferBit5Qcom = ((int)0x00000020),
ColorBufferBit6Qcom = ((int)0x00000040),
ColorBufferBit7Qcom = ((int)0x00000080),
DepthBufferBit0Qcom = ((int)0x00000100),
DepthBufferBit1Qcom = ((int)0x00000200),
DepthBufferBit2Qcom = ((int)0x00000400),
DepthBufferBit3Qcom = ((int)0x00000800),
DepthBufferBit4Qcom = ((int)0x00001000),
DepthBufferBit5Qcom = ((int)0x00002000),
DepthBufferBit6Qcom = ((int)0x00004000),
DepthBufferBit7Qcom = ((int)0x00008000),
StencilBufferBit0Qcom = ((int)0x00010000),
StencilBufferBit1Qcom = ((int)0x00020000),
StencilBufferBit2Qcom = ((int)0x00040000),
StencilBufferBit3Qcom = ((int)0x00080000),
StencilBufferBit4Qcom = ((int)0x00100000),
StencilBufferBit5Qcom = ((int)0x00200000),
StencilBufferBit6Qcom = ((int)0x00400000),
StencilBufferBit7Qcom = ((int)0x00800000),
MultisampleBufferBit0Qcom = ((int)0x01000000),
MultisampleBufferBit1Qcom = ((int)0x02000000),
MultisampleBufferBit2Qcom = ((int)0x04000000),
MultisampleBufferBit3Qcom = ((int)0x08000000),
MultisampleBufferBit4Qcom = ((int)0x10000000),
MultisampleBufferBit5Qcom = ((int)0x20000000),
MultisampleBufferBit6Qcom = ((int)0x40000000),
MultisampleBufferBit7Qcom = unchecked((int)0x80000000),
QcomTiledRendering = ((int)1),
}

public enum QcomTiledRendering : int
{
ColorBufferBit0Qcom = ((int)0x00000001),
ColorBufferBit1Qcom = ((int)0x00000002),
ColorBufferBit2Qcom = ((int)0x00000004),
ColorBufferBit3Qcom = ((int)0x00000008),
ColorBufferBit4Qcom = ((int)0x00000010),
ColorBufferBit5Qcom = ((int)0x00000020),
ColorBufferBit6Qcom = ((int)0x00000040),
ColorBufferBit7Qcom = ((int)0x00000080),
DepthBufferBit0Qcom = ((int)0x00000100),
DepthBufferBit1Qcom = ((int)0x00000200),
DepthBufferBit2Qcom = ((int)0x00000400),
DepthBufferBit3Qcom = ((int)0x00000800),
DepthBufferBit4Qcom = ((int)0x00001000),
DepthBufferBit5Qcom = ((int)0x00002000),
DepthBufferBit6Qcom = ((int)0x00004000),
DepthBufferBit7Qcom = ((int)0x00008000),
StencilBufferBit0Qcom = ((int)0x00010000),
StencilBufferBit1Qcom = ((int)0x00020000),
StencilBufferBit2Qcom = ((int)0x00040000),
StencilBufferBit3Qcom = ((int)0x00080000),
StencilBufferBit4Qcom = ((int)0x00100000),
StencilBufferBit5Qcom = ((int)0x00200000),
StencilBufferBit6Qcom = ((int)0x00400000),
StencilBufferBit7Qcom = ((int)0x00800000),
MultisampleBufferBit0Qcom = ((int)0x01000000),
MultisampleBufferBit1Qcom = ((int)0x02000000),
MultisampleBufferBit2Qcom = ((int)0x04000000),
MultisampleBufferBit3Qcom = ((int)0x08000000),
MultisampleBufferBit4Qcom = ((int)0x10000000),
MultisampleBufferBit5Qcom = ((int)0x20000000),
MultisampleBufferBit6Qcom = ((int)0x40000000),
MultisampleBufferBit7Qcom = unchecked((int)0x80000000),
}

[Obsolete("Use an enum with a similar name and a capital letter at right places")]
public enum QcomwriteonlyRendering : int
{
WriteonlyRenderingQcom = ((int)0x8823),
QcomWriteonlyRendering = ((int)1),
}

public enum QcomWriteonlyRendering : int
{
WriteonlyRenderingQcom = ((int)0x8823),
}

public enum ReadFormat : int
{
ImplementationColorReadType = ((int)0x8B9A),
ImplementationColorReadFormat = ((int)0x8B9B),
}

public enum RenderbufferInternalFormat : int
{
Rgba4 = ((int)0X8056),
Rgb5A1 = ((int)0X8057),
DepthComponent16 = ((int)0X81a5),
StencilIndex8 = ((int)0X8d48),
Rgb565 = ((int)0X8d62),
}

public enum RenderbufferParameterName : int
{
RenderbufferWidth = ((int)0X8d42),
RenderbufferHeight = ((int)0X8d43),
RenderbufferInternalFormat = ((int)0X8d44),
RenderbufferRedSize = ((int)0X8d50),
RenderbufferGreenSize = ((int)0X8d51),
RenderbufferBlueSize = ((int)0X8d52),
RenderbufferAlphaSize = ((int)0X8d53),
RenderbufferDepthSize = ((int)0X8d54),
RenderbufferStencilSize = ((int)0X8d55),
}

public enum RenderbufferTarget : int
{
Renderbuffer = ((int)0X8d41),
}

public enum SeparateBlendFunctions : int
{
ConstantColor = ((int)0x8001),
OneMinusConstantColor = ((int)0x8002),
ConstantAlpha = ((int)0x8003),
OneMinusConstantAlpha = ((int)0x8004),
BlendColor = ((int)0x8005),
BlendDstRgb = ((int)0x80C8),
BlendSrcRgb = ((int)0x80C9),
BlendDstAlpha = ((int)0x80CA),
BlendSrcAlpha = ((int)0x80CB),
}

public enum ShaderBinary : int
{
ShaderBinaryFormats = ((int)0x8DF8),
NumShaderBinaryFormats = ((int)0x8DF9),
}

public enum ShaderBinaryFormat : int
{
}

public enum ShaderParameter : int
{
ShaderType = ((int)0X8b4f),
DeleteStatus = ((int)0X8b80),
CompileStatus = ((int)0X8b81),
InfoLogLength = ((int)0X8b84),
ShaderSourceLength = ((int)0X8b88),
}

public enum ShaderPrecision : int
{
LowFloat = ((int)0X8df0),
MediumFloat = ((int)0X8df1),
HighFloat = ((int)0X8df2),
LowInt = ((int)0X8df3),
MediumInt = ((int)0X8df4),
HighInt = ((int)0X8df5),
}

public enum ShaderPrecisionSpecifiedTypes : int
{
LowFloat = ((int)0x8DF0),
MediumFloat = ((int)0x8DF1),
HighFloat = ((int)0x8DF2),
LowInt = ((int)0x8DF3),
MediumInt = ((int)0x8DF4),
HighInt = ((int)0x8DF5),
}

public enum Shaders : int
{
MaxVertexAttribs = ((int)0x8869),
MaxTextureImageUnits = ((int)0x8872),
FragmentShader = ((int)0x8B30),
VertexShader = ((int)0x8B31),
MaxVertexTextureImageUnits = ((int)0x8B4C),
MaxCombinedTextureImageUnits = ((int)0x8B4D),
ShaderType = ((int)0x8B4F),
DeleteStatus = ((int)0x8B80),
LinkStatus = ((int)0x8B82),
ValidateStatus = ((int)0x8B83),
AttachedShaders = ((int)0x8B85),
ActiveUniforms = ((int)0x8B86),
ActiveUniformMaxLength = ((int)0x8B87),
ActiveAttributes = ((int)0x8B89),
ActiveAttributeMaxLength = ((int)0x8B8A),
ShadingLanguageVersion = ((int)0x8B8C),
CurrentProgram = ((int)0x8B8D),
MaxVertexUniformVectors = ((int)0x8DFB),
MaxVaryingVectors = ((int)0x8DFC),
MaxFragmentUniformVectors = ((int)0x8DFD),
}

public enum ShaderSource : int
{
CompileStatus = ((int)0x8B81),
InfoLogLength = ((int)0x8B84),
ShaderSourceLength = ((int)0x8B88),
ShaderCompiler = ((int)0x8DFA),
}

public enum ShaderType : int
{
FragmentShader = ((int)0X8b30),
VertexShader = ((int)0X8b31),
}

public enum StencilFunction : int
{
Never = ((int)0x0200),
Less = ((int)0x0201),
Equal = ((int)0x0202),
Lequal = ((int)0x0203),
Greater = ((int)0x0204),
Notequal = ((int)0x0205),
Gequal = ((int)0x0206),
Always = ((int)0x0207),
}

public enum StencilOp : int
{
Zero = ((int)0X0000),
Invert = ((int)0x150A),
Keep = ((int)0x1E00),
Replace = ((int)0x1E01),
Incr = ((int)0x1E02),
Decr = ((int)0x1E03),
IncrWrap = ((int)0x8507),
DecrWrap = ((int)0x8508),
}

public enum StringName : int
{
Vendor = ((int)0x1F00),
Renderer = ((int)0x1F01),
Version = ((int)0x1F02),
Extensions = ((int)0x1F03),
ShadingLanguageVersion = ((int)0X8b8c),
}

public enum TextureMagFilter : int
{
Nearest = ((int)0x2600),
Linear = ((int)0x2601),
}

public enum TextureMinFilter : int
{
Nearest = ((int)0X2600),
Linear = ((int)0X2601),
NearestMipmapNearest = ((int)0x2700),
LinearMipmapNearest = ((int)0x2701),
NearestMipmapLinear = ((int)0x2702),
LinearMipmapLinear = ((int)0x2703),
}

public enum TextureParameterName : int
{
TextureMagFilter = ((int)0x2800),
TextureMinFilter = ((int)0x2801),
TextureWrapS = ((int)0x2802),
TextureWrapT = ((int)0x2803),
}

public enum TextureTarget : int
{
Texture2D = ((int)0X0de1),
Texture = ((int)0x1702),
TextureCubeMap = ((int)0x8513),
TextureBindingCubeMap = ((int)0x8514),
TextureCubeMapPositiveX = ((int)0x8515),
TextureCubeMapNegativeX = ((int)0x8516),
TextureCubeMapPositiveY = ((int)0x8517),
TextureCubeMapNegativeY = ((int)0x8518),
TextureCubeMapPositiveZ = ((int)0x8519),
TextureCubeMapNegativeZ = ((int)0x851A),
MaxCubeMapTextureSize = ((int)0x851C),
}

public enum TextureUnit : int
{
Texture0 = ((int)0x84C0),
Texture1 = ((int)0x84C1),
Texture2 = ((int)0x84C2),
Texture3 = ((int)0x84C3),
Texture4 = ((int)0x84C4),
Texture5 = ((int)0x84C5),
Texture6 = ((int)0x84C6),
Texture7 = ((int)0x84C7),
Texture8 = ((int)0x84C8),
Texture9 = ((int)0x84C9),
Texture10 = ((int)0x84CA),
Texture11 = ((int)0x84CB),
Texture12 = ((int)0x84CC),
Texture13 = ((int)0x84CD),
Texture14 = ((int)0x84CE),
Texture15 = ((int)0x84CF),
Texture16 = ((int)0x84D0),
Texture17 = ((int)0x84D1),
Texture18 = ((int)0x84D2),
Texture19 = ((int)0x84D3),
Texture20 = ((int)0x84D4),
Texture21 = ((int)0x84D5),
Texture22 = ((int)0x84D6),
Texture23 = ((int)0x84D7),
Texture24 = ((int)0x84D8),
Texture25 = ((int)0x84D9),
Texture26 = ((int)0x84DA),
Texture27 = ((int)0x84DB),
Texture28 = ((int)0x84DC),
Texture29 = ((int)0x84DD),
Texture30 = ((int)0x84DE),
Texture31 = ((int)0x84DF),
ActiveTexture = ((int)0x84E0),
}

public enum TextureWrapMode : int
{
Repeat = ((int)0x2901),
ClampToEdge = ((int)0x812F),
MirroredRepeat = ((int)0x8370),
}

public enum UniformTypes : int
{
FloatVec2 = ((int)0x8B50),
FloatVec3 = ((int)0x8B51),
FloatVec4 = ((int)0x8B52),
IntVec2 = ((int)0x8B53),
IntVec3 = ((int)0x8B54),
IntVec4 = ((int)0x8B55),
Bool = ((int)0x8B56),
BoolVec2 = ((int)0x8B57),
BoolVec3 = ((int)0x8B58),
BoolVec4 = ((int)0x8B59),
FloatMat2 = ((int)0x8B5A),
FloatMat3 = ((int)0x8B5B),
FloatMat4 = ((int)0x8B5C),
Sampler2D = ((int)0x8B5E),
SamplerCube = ((int)0x8B60),
}

public enum Unknown : int
{
ImgTextureFormatBgra8888 = ((int)0X0001),
ExtMultiDrawArrays = ((int)1),
}

public enum VertexArrays : int
{
VertexAttribArrayEnabled = ((int)0x8622),
VertexAttribArraySize = ((int)0x8623),
VertexAttribArrayStride = ((int)0x8624),
VertexAttribArrayType = ((int)0x8625),
VertexAttribArrayPointer = ((int)0x8645),
VertexAttribArrayNormalized = ((int)0x886A),
VertexAttribArrayBufferBinding = ((int)0x889F),
}

public enum VertexAttribParameter : int
{
VertexAttribArrayEnabled = ((int)0X8622),
VertexAttribArraySize = ((int)0X8623),
VertexAttribArrayStride = ((int)0X8624),
VertexAttribArrayType = ((int)0X8625),
CurrentVertexAttrib = ((int)0X8626),
VertexAttribArrayNormalized = ((int)0X886a),
VertexAttribArrayBufferBinding = ((int)0X889f),
}

public enum VertexAttribPointerParameter : int
{
VertexAttribArrayPointer = ((int)0X8645),
}

public enum VertexAttribPointerType : int
{
Byte = ((int)0X1400),
UnsignedByte = ((int)0X1401),
Short = ((int)0X1402),
UnsignedShort = ((int)0X1403),
Float = ((int)0X1406),
Fixed = ((int)0X140c),
}

public enum VivShaderBinary : int
{
ShaderBinaryViv = ((int)0x8FC4),
}

}
