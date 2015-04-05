//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace touchvg.core {

public class GiCanvas : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GiCanvas(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GiCanvas obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GiCanvas() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_GiCanvas(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void setPen(int argb, float width, int style, float phase, float orgw) {
    touchvgPINVOKE.GiCanvas_setPen(swigCPtr, argb, width, style, phase, orgw);
  }

  public virtual void setBrush(int argb, int style) {
    touchvgPINVOKE.GiCanvas_setBrush(swigCPtr, argb, style);
  }

  public virtual void clearRect(float x, float y, float w, float h) {
    touchvgPINVOKE.GiCanvas_clearRect(swigCPtr, x, y, w, h);
  }

  public virtual void drawRect(float x, float y, float w, float h, bool stroke, bool fill) {
    touchvgPINVOKE.GiCanvas_drawRect(swigCPtr, x, y, w, h, stroke, fill);
  }

  public virtual void drawLine(float x1, float y1, float x2, float y2) {
    touchvgPINVOKE.GiCanvas_drawLine(swigCPtr, x1, y1, x2, y2);
  }

  public virtual void drawEllipse(float x, float y, float w, float h, bool stroke, bool fill) {
    touchvgPINVOKE.GiCanvas_drawEllipse(swigCPtr, x, y, w, h, stroke, fill);
  }

  public virtual void beginPath() {
    touchvgPINVOKE.GiCanvas_beginPath(swigCPtr);
  }

  public virtual void moveTo(float x, float y) {
    touchvgPINVOKE.GiCanvas_moveTo(swigCPtr, x, y);
  }

  public virtual void lineTo(float x, float y) {
    touchvgPINVOKE.GiCanvas_lineTo(swigCPtr, x, y);
  }

  public virtual void bezierTo(float c1x, float c1y, float c2x, float c2y, float x, float y) {
    touchvgPINVOKE.GiCanvas_bezierTo(swigCPtr, c1x, c1y, c2x, c2y, x, y);
  }

  public virtual void quadTo(float cpx, float cpy, float x, float y) {
    touchvgPINVOKE.GiCanvas_quadTo(swigCPtr, cpx, cpy, x, y);
  }

  public virtual void closePath() {
    touchvgPINVOKE.GiCanvas_closePath(swigCPtr);
  }

  public virtual void drawPath(bool stroke, bool fill) {
    touchvgPINVOKE.GiCanvas_drawPath(swigCPtr, stroke, fill);
  }

  public virtual void saveClip() {
    touchvgPINVOKE.GiCanvas_saveClip(swigCPtr);
  }

  public virtual void restoreClip() {
    touchvgPINVOKE.GiCanvas_restoreClip(swigCPtr);
  }

  public virtual bool clipRect(float x, float y, float w, float h) {
    bool ret = touchvgPINVOKE.GiCanvas_clipRect(swigCPtr, x, y, w, h);
    return ret;
  }

  public virtual bool clipPath() {
    bool ret = touchvgPINVOKE.GiCanvas_clipPath(swigCPtr);
    return ret;
  }

  public virtual bool drawHandle(float x, float y, int type, float angle) {
    bool ret = touchvgPINVOKE.GiCanvas_drawHandle(swigCPtr, x, y, type, angle);
    return ret;
  }

  public virtual bool drawBitmap(string name, float xc, float yc, float w, float h, float angle) {
    bool ret = touchvgPINVOKE.GiCanvas_drawBitmap(swigCPtr, name, xc, yc, w, h, angle);
    return ret;
  }

  public virtual float drawTextAt(string text, float x, float y, float h, int align, float angle) {
    float ret = touchvgPINVOKE.GiCanvas_drawTextAt(swigCPtr, text, x, y, h, align, angle);
    return ret;
  }

  public virtual bool beginShape(int type, int sid, int version, float x, float y, float w, float h) {
    bool ret = (SwigDerivedClassHasMethod("beginShape", swigMethodTypes20) ? touchvgPINVOKE.GiCanvas_beginShapeSwigExplicitGiCanvas(swigCPtr, type, sid, version, x, y, w, h) : touchvgPINVOKE.GiCanvas_beginShape(swigCPtr, type, sid, version, x, y, w, h));
    return ret;
  }

  public virtual void endShape(int type, int sid, float x, float y) {
    if (SwigDerivedClassHasMethod("endShape", swigMethodTypes21)) touchvgPINVOKE.GiCanvas_endShapeSwigExplicitGiCanvas(swigCPtr, type, sid, x, y); else touchvgPINVOKE.GiCanvas_endShape(swigCPtr, type, sid, x, y);
  }

  public GiCanvas() : this(touchvgPINVOKE.new_GiCanvas(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("setPen", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateGiCanvas_0(SwigDirectorsetPen);
    if (SwigDerivedClassHasMethod("setBrush", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateGiCanvas_1(SwigDirectorsetBrush);
    if (SwigDerivedClassHasMethod("clearRect", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateGiCanvas_2(SwigDirectorclearRect);
    if (SwigDerivedClassHasMethod("drawRect", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateGiCanvas_3(SwigDirectordrawRect);
    if (SwigDerivedClassHasMethod("drawLine", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateGiCanvas_4(SwigDirectordrawLine);
    if (SwigDerivedClassHasMethod("drawEllipse", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateGiCanvas_5(SwigDirectordrawEllipse);
    if (SwigDerivedClassHasMethod("beginPath", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateGiCanvas_6(SwigDirectorbeginPath);
    if (SwigDerivedClassHasMethod("moveTo", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateGiCanvas_7(SwigDirectormoveTo);
    if (SwigDerivedClassHasMethod("lineTo", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateGiCanvas_8(SwigDirectorlineTo);
    if (SwigDerivedClassHasMethod("bezierTo", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateGiCanvas_9(SwigDirectorbezierTo);
    if (SwigDerivedClassHasMethod("quadTo", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateGiCanvas_10(SwigDirectorquadTo);
    if (SwigDerivedClassHasMethod("closePath", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateGiCanvas_11(SwigDirectorclosePath);
    if (SwigDerivedClassHasMethod("drawPath", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateGiCanvas_12(SwigDirectordrawPath);
    if (SwigDerivedClassHasMethod("saveClip", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateGiCanvas_13(SwigDirectorsaveClip);
    if (SwigDerivedClassHasMethod("restoreClip", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateGiCanvas_14(SwigDirectorrestoreClip);
    if (SwigDerivedClassHasMethod("clipRect", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateGiCanvas_15(SwigDirectorclipRect);
    if (SwigDerivedClassHasMethod("clipPath", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateGiCanvas_16(SwigDirectorclipPath);
    if (SwigDerivedClassHasMethod("drawHandle", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateGiCanvas_17(SwigDirectordrawHandle);
    if (SwigDerivedClassHasMethod("drawBitmap", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateGiCanvas_18(SwigDirectordrawBitmap);
    if (SwigDerivedClassHasMethod("drawTextAt", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateGiCanvas_19(SwigDirectordrawTextAt);
    if (SwigDerivedClassHasMethod("beginShape", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateGiCanvas_20(SwigDirectorbeginShape);
    if (SwigDerivedClassHasMethod("endShape", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateGiCanvas_21(SwigDirectorendShape);
    touchvgPINVOKE.GiCanvas_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(GiCanvas));
    return hasDerivedMethod;
  }

  private void SwigDirectorsetPen(int argb, float width, int style, float phase, float orgw) {
    setPen(argb, width, style, phase, orgw);
  }

  private void SwigDirectorsetBrush(int argb, int style) {
    setBrush(argb, style);
  }

  private void SwigDirectorclearRect(float x, float y, float w, float h) {
    clearRect(x, y, w, h);
  }

  private void SwigDirectordrawRect(float x, float y, float w, float h, bool stroke, bool fill) {
    drawRect(x, y, w, h, stroke, fill);
  }

  private void SwigDirectordrawLine(float x1, float y1, float x2, float y2) {
    drawLine(x1, y1, x2, y2);
  }

  private void SwigDirectordrawEllipse(float x, float y, float w, float h, bool stroke, bool fill) {
    drawEllipse(x, y, w, h, stroke, fill);
  }

  private void SwigDirectorbeginPath() {
    beginPath();
  }

  private void SwigDirectormoveTo(float x, float y) {
    moveTo(x, y);
  }

  private void SwigDirectorlineTo(float x, float y) {
    lineTo(x, y);
  }

  private void SwigDirectorbezierTo(float c1x, float c1y, float c2x, float c2y, float x, float y) {
    bezierTo(c1x, c1y, c2x, c2y, x, y);
  }

  private void SwigDirectorquadTo(float cpx, float cpy, float x, float y) {
    quadTo(cpx, cpy, x, y);
  }

  private void SwigDirectorclosePath() {
    closePath();
  }

  private void SwigDirectordrawPath(bool stroke, bool fill) {
    drawPath(stroke, fill);
  }

  private void SwigDirectorsaveClip() {
    saveClip();
  }

  private void SwigDirectorrestoreClip() {
    restoreClip();
  }

  private bool SwigDirectorclipRect(float x, float y, float w, float h) {
    return clipRect(x, y, w, h);
  }

  private bool SwigDirectorclipPath() {
    return clipPath();
  }

  private bool SwigDirectordrawHandle(float x, float y, int type, float angle) {
    return drawHandle(x, y, type, angle);
  }

  private bool SwigDirectordrawBitmap(string name, float xc, float yc, float w, float h, float angle) {
    return drawBitmap(name, xc, yc, w, h, angle);
  }

  private float SwigDirectordrawTextAt(string text, float x, float y, float h, int align, float angle) {
    return drawTextAt(text, x, y, h, align, angle);
  }

  private bool SwigDirectorbeginShape(int type, int sid, int version, float x, float y, float w, float h) {
    return beginShape(type, sid, version, x, y, w, h);
  }

  private void SwigDirectorendShape(int type, int sid, float x, float y) {
    endShape(type, sid, x, y);
  }

  public delegate void SwigDelegateGiCanvas_0(int argb, float width, int style, float phase, float orgw);
  public delegate void SwigDelegateGiCanvas_1(int argb, int style);
  public delegate void SwigDelegateGiCanvas_2(float x, float y, float w, float h);
  public delegate void SwigDelegateGiCanvas_3(float x, float y, float w, float h, bool stroke, bool fill);
  public delegate void SwigDelegateGiCanvas_4(float x1, float y1, float x2, float y2);
  public delegate void SwigDelegateGiCanvas_5(float x, float y, float w, float h, bool stroke, bool fill);
  public delegate void SwigDelegateGiCanvas_6();
  public delegate void SwigDelegateGiCanvas_7(float x, float y);
  public delegate void SwigDelegateGiCanvas_8(float x, float y);
  public delegate void SwigDelegateGiCanvas_9(float c1x, float c1y, float c2x, float c2y, float x, float y);
  public delegate void SwigDelegateGiCanvas_10(float cpx, float cpy, float x, float y);
  public delegate void SwigDelegateGiCanvas_11();
  public delegate void SwigDelegateGiCanvas_12(bool stroke, bool fill);
  public delegate void SwigDelegateGiCanvas_13();
  public delegate void SwigDelegateGiCanvas_14();
  public delegate bool SwigDelegateGiCanvas_15(float x, float y, float w, float h);
  public delegate bool SwigDelegateGiCanvas_16();
  public delegate bool SwigDelegateGiCanvas_17(float x, float y, int type, float angle);
  public delegate bool SwigDelegateGiCanvas_18(string name, float xc, float yc, float w, float h, float angle);
  public delegate float SwigDelegateGiCanvas_19(string text, float x, float y, float h, int align, float angle);
  public delegate bool SwigDelegateGiCanvas_20(int type, int sid, int version, float x, float y, float w, float h);
  public delegate void SwigDelegateGiCanvas_21(int type, int sid, float x, float y);

  private SwigDelegateGiCanvas_0 swigDelegate0;
  private SwigDelegateGiCanvas_1 swigDelegate1;
  private SwigDelegateGiCanvas_2 swigDelegate2;
  private SwigDelegateGiCanvas_3 swigDelegate3;
  private SwigDelegateGiCanvas_4 swigDelegate4;
  private SwigDelegateGiCanvas_5 swigDelegate5;
  private SwigDelegateGiCanvas_6 swigDelegate6;
  private SwigDelegateGiCanvas_7 swigDelegate7;
  private SwigDelegateGiCanvas_8 swigDelegate8;
  private SwigDelegateGiCanvas_9 swigDelegate9;
  private SwigDelegateGiCanvas_10 swigDelegate10;
  private SwigDelegateGiCanvas_11 swigDelegate11;
  private SwigDelegateGiCanvas_12 swigDelegate12;
  private SwigDelegateGiCanvas_13 swigDelegate13;
  private SwigDelegateGiCanvas_14 swigDelegate14;
  private SwigDelegateGiCanvas_15 swigDelegate15;
  private SwigDelegateGiCanvas_16 swigDelegate16;
  private SwigDelegateGiCanvas_17 swigDelegate17;
  private SwigDelegateGiCanvas_18 swigDelegate18;
  private SwigDelegateGiCanvas_19 swigDelegate19;
  private SwigDelegateGiCanvas_20 swigDelegate20;
  private SwigDelegateGiCanvas_21 swigDelegate21;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(int), typeof(float), typeof(int), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(int), typeof(int) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool), typeof(bool) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(bool), typeof(bool) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] { typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(float), typeof(float), typeof(int), typeof(float) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] { typeof(string), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(string), typeof(float), typeof(float), typeof(float), typeof(int), typeof(float) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(int), typeof(int), typeof(int), typeof(float), typeof(float), typeof(float), typeof(float) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(int), typeof(int), typeof(float), typeof(float) };
  public static readonly int kLineDashMask = touchvgPINVOKE.GiCanvas_kLineDashMask_get();
  public static readonly int kLineCapDefault = touchvgPINVOKE.GiCanvas_kLineCapDefault_get();
  public static readonly int kLineCapMask = touchvgPINVOKE.GiCanvas_kLineCapMask_get();
  public static readonly int kLineCapButt = touchvgPINVOKE.GiCanvas_kLineCapButt_get();
  public static readonly int kLineCapRound = touchvgPINVOKE.GiCanvas_kLineCapRound_get();
  public static readonly int kLineCapSquare = touchvgPINVOKE.GiCanvas_kLineCapSquare_get();
  public static readonly int kAlignLeft = touchvgPINVOKE.GiCanvas_kAlignLeft_get();
  public static readonly int kAlignCenter = touchvgPINVOKE.GiCanvas_kAlignCenter_get();
  public static readonly int kAlignRight = touchvgPINVOKE.GiCanvas_kAlignRight_get();
  public static readonly int kAlignHorz = touchvgPINVOKE.GiCanvas_kAlignHorz_get();
  public static readonly int kAlignTop = touchvgPINVOKE.GiCanvas_kAlignTop_get();
  public static readonly int kAlignBottom = touchvgPINVOKE.GiCanvas_kAlignBottom_get();
  public static readonly int kAlignVCenter = touchvgPINVOKE.GiCanvas_kAlignVCenter_get();
  public static readonly int kAlignVert = touchvgPINVOKE.GiCanvas_kAlignVert_get();

}

}
