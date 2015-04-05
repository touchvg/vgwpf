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

public class MgBaseRect : MgBaseShape {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgBaseRect(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgBaseRect_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgBaseRect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgBaseRect() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgBaseRect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgBaseRect_Type();
    return ret;
  }

  public Point2d getCenter() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgBaseRect_getCenter(swigCPtr), true);
    return ret;
  }

  public Box2d getRect() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgBaseRect_getRect(swigCPtr), true);
    return ret;
  }

  public float getWidth() {
    float ret = touchvgPINVOKE.MgBaseRect_getWidth(swigCPtr);
    return ret;
  }

  public float getHeight() {
    float ret = touchvgPINVOKE.MgBaseRect_getHeight(swigCPtr);
    return ret;
  }

  public float getDiagonalLength() {
    float ret = touchvgPINVOKE.MgBaseRect_getDiagonalLength(swigCPtr);
    return ret;
  }

  public float getAngle() {
    float ret = touchvgPINVOKE.MgBaseRect_getAngle(swigCPtr);
    return ret;
  }

  public bool isEmpty(float minDist) {
    bool ret = touchvgPINVOKE.MgBaseRect_isEmpty(swigCPtr, minDist);
    return ret;
  }

  public bool isOrtho() {
    bool ret = touchvgPINVOKE.MgBaseRect_isOrtho(swigCPtr);
    return ret;
  }

  public void setRect2P(Point2d pt1, Point2d pt2) {
    touchvgPINVOKE.MgBaseRect_setRect2P(swigCPtr, Point2d.getCPtr(pt1), Point2d.getCPtr(pt2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRectWithAngle(Point2d pt1, Point2d pt2, float angle, Point2d basept) {
    touchvgPINVOKE.MgBaseRect_setRectWithAngle(swigCPtr, Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), angle, Point2d.getCPtr(basept));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setRect4P(Point2d points) {
    touchvgPINVOKE.MgBaseRect_setRect4P(swigCPtr, Point2d.getCPtr(points));
  }

  public bool transformWith2P(Point2d pt1, int i1, Point2d pt2, int i2) {
    bool ret = touchvgPINVOKE.MgBaseRect_transformWith2P(swigCPtr, Point2d.getCPtr(pt1), i1, Point2d.getCPtr(pt2), i2);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCenter(Point2d pt) {
    touchvgPINVOKE.MgBaseRect_setCenter(swigCPtr, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setSquare(bool square) {
    touchvgPINVOKE.MgBaseRect_setSquare(swigCPtr, square);
  }

  protected MgBaseRect() : this(touchvgPINVOKE.new_MgBaseRect(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("clone", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgBaseRect_0(SwigDirectorclone);
    if (SwigDerivedClassHasMethod("copy", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgBaseRect_1(SwigDirectorcopy);
    if (SwigDerivedClassHasMethod("release", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgBaseRect_2(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("addRef", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgBaseRect_3(SwigDirectoraddRef);
    if (SwigDerivedClassHasMethod("equals", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgBaseRect_4(SwigDirectorequals);
    if (SwigDerivedClassHasMethod("getType", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgBaseRect_5(SwigDirectorgetType);
    if (SwigDerivedClassHasMethod("isKindOf", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgBaseRect_6(SwigDirectorisKindOf);
    if (SwigDerivedClassHasMethod("getExtent", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgBaseRect_7(SwigDirectorgetExtent);
    if (SwigDerivedClassHasMethod("getChangeCount", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgBaseRect_8(SwigDirectorgetChangeCount);
    if (SwigDerivedClassHasMethod("resetChangeCount", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgBaseRect_9(SwigDirectorresetChangeCount);
    if (SwigDerivedClassHasMethod("afterChanged", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgBaseRect_10(SwigDirectorafterChanged);
    if (SwigDerivedClassHasMethod("update", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgBaseRect_11(SwigDirectorupdate);
    if (SwigDerivedClassHasMethod("transform", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgBaseRect_12(SwigDirectortransform);
    if (SwigDerivedClassHasMethod("clear", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgBaseRect_13(SwigDirectorclear);
    if (SwigDerivedClassHasMethod("clearCachedData", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgBaseRect_14(SwigDirectorclearCachedData);
    if (SwigDerivedClassHasMethod("getPointCount", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgBaseRect_15(SwigDirectorgetPointCount);
    if (SwigDerivedClassHasMethod("getPoint", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgBaseRect_16(SwigDirectorgetPoint);
    if (SwigDerivedClassHasMethod("setPoint", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgBaseRect_17(SwigDirectorsetPoint);
    if (SwigDerivedClassHasMethod("isClosed", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgBaseRect_18(SwigDirectorisClosed);
    if (SwigDerivedClassHasMethod("isCurve", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgBaseRect_19(SwigDirectorisCurve);
    if (SwigDerivedClassHasMethod("hitTest", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateMgBaseRect_20(SwigDirectorhitTest);
    if (SwigDerivedClassHasMethod("hitTestBox", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateMgBaseRect_21(SwigDirectorhitTestBox);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateMgBaseRect_22(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("draw2", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateMgBaseRect_23(SwigDirectordraw2);
    if (SwigDerivedClassHasMethod("output", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateMgBaseRect_24(SwigDirectoroutput);
    if (SwigDerivedClassHasMethod("save", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateMgBaseRect_25(SwigDirectorsave);
    if (SwigDerivedClassHasMethod("load", swigMethodTypes26))
      swigDelegate26 = new SwigDelegateMgBaseRect_26(SwigDirectorload);
    if (SwigDerivedClassHasMethod("getHandleCount", swigMethodTypes27))
      swigDelegate27 = new SwigDelegateMgBaseRect_27(SwigDirectorgetHandleCount);
    if (SwigDerivedClassHasMethod("getHandlePoint", swigMethodTypes28))
      swigDelegate28 = new SwigDelegateMgBaseRect_28(SwigDirectorgetHandlePoint);
    if (SwigDerivedClassHasMethod("setHandlePoint", swigMethodTypes29))
      swigDelegate29 = new SwigDelegateMgBaseRect_29(SwigDirectorsetHandlePoint);
    if (SwigDerivedClassHasMethod("isHandleFixed", swigMethodTypes30))
      swigDelegate30 = new SwigDelegateMgBaseRect_30(SwigDirectorisHandleFixed);
    if (SwigDerivedClassHasMethod("getHandleType", swigMethodTypes31))
      swigDelegate31 = new SwigDelegateMgBaseRect_31(SwigDirectorgetHandleType);
    if (SwigDerivedClassHasMethod("offset", swigMethodTypes32))
      swigDelegate32 = new SwigDelegateMgBaseRect_32(SwigDirectoroffset);
    if (SwigDerivedClassHasMethod("setFlag", swigMethodTypes33))
      swigDelegate33 = new SwigDelegateMgBaseRect_33(SwigDirectorsetFlag);
    if (SwigDerivedClassHasMethod("setOwner", swigMethodTypes34))
      swigDelegate34 = new SwigDelegateMgBaseRect_34(SwigDirectorsetOwner);
    if (SwigDerivedClassHasMethod("getSubType", swigMethodTypes35))
      swigDelegate35 = new SwigDelegateMgBaseRect_35(SwigDirectorgetSubType);
    touchvgPINVOKE.MgBaseRect_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25, swigDelegate26, swigDelegate27, swigDelegate28, swigDelegate29, swigDelegate30, swigDelegate31, swigDelegate32, swigDelegate33, swigDelegate34, swigDelegate35);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgBaseRect));
    return hasDerivedMethod;
  }

  private global::System.IntPtr SwigDirectorclone() {
    return MgObject.getCPtr(clone()).Handle;
  }

  private void SwigDirectorcopy(global::System.IntPtr src) {
    copy(new MgObject(src, false));
  }

  private void SwigDirectorrelease() {
    release();
  }

  private void SwigDirectoraddRef() {
    addRef();
  }

  private bool SwigDirectorequals(global::System.IntPtr src) {
    return equals(new MgObject(src, false));
  }

  private int SwigDirectorgetType() {
    return getType();
  }

  private bool SwigDirectorisKindOf(int type) {
    return isKindOf(type);
  }

  private global::System.IntPtr SwigDirectorgetExtent() {
    return Box2d.getCPtr(getExtent()).Handle;
  }

  private int SwigDirectorgetChangeCount() {
    return getChangeCount();
  }

  private void SwigDirectorresetChangeCount(int count) {
    resetChangeCount(count);
  }

  private void SwigDirectorafterChanged() {
    afterChanged();
  }

  private void SwigDirectorupdate() {
    update();
  }

  private void SwigDirectortransform(global::System.IntPtr mat) {
    transform(new Matrix2d(mat, false));
  }

  private void SwigDirectorclear() {
    clear();
  }

  private void SwigDirectorclearCachedData() {
    clearCachedData();
  }

  private int SwigDirectorgetPointCount() {
    return getPointCount();
  }

  private global::System.IntPtr SwigDirectorgetPoint(int index) {
    return Point2d.getCPtr(getPoint(index)).Handle;
  }

  private void SwigDirectorsetPoint(int index, global::System.IntPtr pt) {
    setPoint(index, new Point2d(pt, false));
  }

  private bool SwigDirectorisClosed() {
    return isClosed();
  }

  private bool SwigDirectorisCurve() {
    return isCurve();
  }

  private float SwigDirectorhitTest(global::System.IntPtr pt, float tol, global::System.IntPtr res) {
    return hitTest(new Point2d(pt, false), tol, new MgHitResult(res, false));
  }

  private bool SwigDirectorhitTestBox(global::System.IntPtr rect) {
    return hitTestBox(new Box2d(rect, false));
  }

  private bool SwigDirectordraw(int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment) {
    return draw(mode, new GiGraphics(gs, false), new GiContext(ctx, false), segment);
  }

  private bool SwigDirectordraw2(global::System.IntPtr owner, int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment) {
    return draw2((owner == global::System.IntPtr.Zero) ? null : new MgObject(owner, false), mode, new GiGraphics(gs, false), new GiContext(ctx, false), segment);
  }

  private void SwigDirectoroutput(global::System.IntPtr path) {
    output(new MgPath(path, false));
  }

  private bool SwigDirectorsave(global::System.IntPtr s) {
    return save((s == global::System.IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private bool SwigDirectorload(global::System.IntPtr factory, global::System.IntPtr s) {
    return load((factory == global::System.IntPtr.Zero) ? null : new MgShapeFactory(factory, false), (s == global::System.IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private int SwigDirectorgetHandleCount() {
    return getHandleCount();
  }

  private global::System.IntPtr SwigDirectorgetHandlePoint(int index) {
    return Point2d.getCPtr(getHandlePoint(index)).Handle;
  }

  private bool SwigDirectorsetHandlePoint(int index, global::System.IntPtr pt, float tol) {
    return setHandlePoint(index, new Point2d(pt, false), tol);
  }

  private bool SwigDirectorisHandleFixed(int index) {
    return isHandleFixed(index);
  }

  private int SwigDirectorgetHandleType(int index) {
    return getHandleType(index);
  }

  private bool SwigDirectoroffset(global::System.IntPtr vec, int segment) {
    return offset(new Vector2d(vec, false), segment);
  }

  private void SwigDirectorsetFlag(int bit, bool on) {
    setFlag((MgShapeBit)bit, on);
  }

  private void SwigDirectorsetOwner(global::System.IntPtr owner) {
    setOwner((owner == global::System.IntPtr.Zero) ? null : new MgObject(owner, false));
  }

  private int SwigDirectorgetSubType() {
    return getSubType();
  }

  public delegate global::System.IntPtr SwigDelegateMgBaseRect_0();
  public delegate void SwigDelegateMgBaseRect_1(global::System.IntPtr src);
  public delegate void SwigDelegateMgBaseRect_2();
  public delegate void SwigDelegateMgBaseRect_3();
  public delegate bool SwigDelegateMgBaseRect_4(global::System.IntPtr src);
  public delegate int SwigDelegateMgBaseRect_5();
  public delegate bool SwigDelegateMgBaseRect_6(int type);
  public delegate global::System.IntPtr SwigDelegateMgBaseRect_7();
  public delegate int SwigDelegateMgBaseRect_8();
  public delegate void SwigDelegateMgBaseRect_9(int count);
  public delegate void SwigDelegateMgBaseRect_10();
  public delegate void SwigDelegateMgBaseRect_11();
  public delegate void SwigDelegateMgBaseRect_12(global::System.IntPtr mat);
  public delegate void SwigDelegateMgBaseRect_13();
  public delegate void SwigDelegateMgBaseRect_14();
  public delegate int SwigDelegateMgBaseRect_15();
  public delegate global::System.IntPtr SwigDelegateMgBaseRect_16(int index);
  public delegate void SwigDelegateMgBaseRect_17(int index, global::System.IntPtr pt);
  public delegate bool SwigDelegateMgBaseRect_18();
  public delegate bool SwigDelegateMgBaseRect_19();
  public delegate float SwigDelegateMgBaseRect_20(global::System.IntPtr pt, float tol, global::System.IntPtr res);
  public delegate bool SwigDelegateMgBaseRect_21(global::System.IntPtr rect);
  public delegate bool SwigDelegateMgBaseRect_22(int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment);
  public delegate bool SwigDelegateMgBaseRect_23(global::System.IntPtr owner, int mode, global::System.IntPtr gs, global::System.IntPtr ctx, int segment);
  public delegate void SwigDelegateMgBaseRect_24(global::System.IntPtr path);
  public delegate bool SwigDelegateMgBaseRect_25(global::System.IntPtr s);
  public delegate bool SwigDelegateMgBaseRect_26(global::System.IntPtr factory, global::System.IntPtr s);
  public delegate int SwigDelegateMgBaseRect_27();
  public delegate global::System.IntPtr SwigDelegateMgBaseRect_28(int index);
  public delegate bool SwigDelegateMgBaseRect_29(int index, global::System.IntPtr pt, float tol);
  public delegate bool SwigDelegateMgBaseRect_30(int index);
  public delegate int SwigDelegateMgBaseRect_31(int index);
  public delegate bool SwigDelegateMgBaseRect_32(global::System.IntPtr vec, int segment);
  public delegate void SwigDelegateMgBaseRect_33(int bit, bool on);
  public delegate void SwigDelegateMgBaseRect_34(global::System.IntPtr owner);
  public delegate int SwigDelegateMgBaseRect_35();

  private SwigDelegateMgBaseRect_0 swigDelegate0;
  private SwigDelegateMgBaseRect_1 swigDelegate1;
  private SwigDelegateMgBaseRect_2 swigDelegate2;
  private SwigDelegateMgBaseRect_3 swigDelegate3;
  private SwigDelegateMgBaseRect_4 swigDelegate4;
  private SwigDelegateMgBaseRect_5 swigDelegate5;
  private SwigDelegateMgBaseRect_6 swigDelegate6;
  private SwigDelegateMgBaseRect_7 swigDelegate7;
  private SwigDelegateMgBaseRect_8 swigDelegate8;
  private SwigDelegateMgBaseRect_9 swigDelegate9;
  private SwigDelegateMgBaseRect_10 swigDelegate10;
  private SwigDelegateMgBaseRect_11 swigDelegate11;
  private SwigDelegateMgBaseRect_12 swigDelegate12;
  private SwigDelegateMgBaseRect_13 swigDelegate13;
  private SwigDelegateMgBaseRect_14 swigDelegate14;
  private SwigDelegateMgBaseRect_15 swigDelegate15;
  private SwigDelegateMgBaseRect_16 swigDelegate16;
  private SwigDelegateMgBaseRect_17 swigDelegate17;
  private SwigDelegateMgBaseRect_18 swigDelegate18;
  private SwigDelegateMgBaseRect_19 swigDelegate19;
  private SwigDelegateMgBaseRect_20 swigDelegate20;
  private SwigDelegateMgBaseRect_21 swigDelegate21;
  private SwigDelegateMgBaseRect_22 swigDelegate22;
  private SwigDelegateMgBaseRect_23 swigDelegate23;
  private SwigDelegateMgBaseRect_24 swigDelegate24;
  private SwigDelegateMgBaseRect_25 swigDelegate25;
  private SwigDelegateMgBaseRect_26 swigDelegate26;
  private SwigDelegateMgBaseRect_27 swigDelegate27;
  private SwigDelegateMgBaseRect_28 swigDelegate28;
  private SwigDelegateMgBaseRect_29 swigDelegate29;
  private SwigDelegateMgBaseRect_30 swigDelegate30;
  private SwigDelegateMgBaseRect_31 swigDelegate31;
  private SwigDelegateMgBaseRect_32 swigDelegate32;
  private SwigDelegateMgBaseRect_33 swigDelegate33;
  private SwigDelegateMgBaseRect_34 swigDelegate34;
  private SwigDelegateMgBaseRect_35 swigDelegate35;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(MgObject) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(MgObject) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(Matrix2d) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] { typeof(int), typeof(Point2d) };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(Point2d), typeof(float), typeof(MgHitResult) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(Box2d) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(int), typeof(GiGraphics), typeof(GiContext), typeof(int) };
  private static global::System.Type[] swigMethodTypes23 = new global::System.Type[] { typeof(MgObject), typeof(int), typeof(GiGraphics), typeof(GiContext), typeof(int) };
  private static global::System.Type[] swigMethodTypes24 = new global::System.Type[] { typeof(MgPath) };
  private static global::System.Type[] swigMethodTypes25 = new global::System.Type[] { typeof(MgStorage) };
  private static global::System.Type[] swigMethodTypes26 = new global::System.Type[] { typeof(MgShapeFactory), typeof(MgStorage) };
  private static global::System.Type[] swigMethodTypes27 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes28 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes29 = new global::System.Type[] { typeof(int), typeof(Point2d), typeof(float) };
  private static global::System.Type[] swigMethodTypes30 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes31 = new global::System.Type[] { typeof(int) };
  private static global::System.Type[] swigMethodTypes32 = new global::System.Type[] { typeof(Vector2d), typeof(int) };
  private static global::System.Type[] swigMethodTypes33 = new global::System.Type[] { typeof(MgShapeBit), typeof(bool) };
  private static global::System.Type[] swigMethodTypes34 = new global::System.Type[] { typeof(MgObject) };
  private static global::System.Type[] swigMethodTypes35 = new global::System.Type[] {  };
}

}
