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

public class MgCmdDrawRect : MgCommandDraw {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgCmdDrawRect(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgCmdDrawRect_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgCmdDrawRect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCmdDrawRect() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCmdDrawRect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgCmdDrawRect(string name) : this(touchvgPINVOKE.new_MgCmdDrawRect__SWIG_0(name), true) {
    SwigDirectorConnect();
  }

  public MgCmdDrawRect() : this(touchvgPINVOKE.new_MgCmdDrawRect__SWIG_1(), true) {
    SwigDirectorConnect();
  }

  public override void release() {
    if (SwigDerivedClassHasMethod("release", swigMethodTypes0)) touchvgPINVOKE.MgCmdDrawRect_releaseSwigExplicitMgCmdDrawRect(swigCPtr); else touchvgPINVOKE.MgCmdDrawRect_release(swigCPtr);
  }

  public override bool initialize(MgMotion sender, MgStorage s) {
    bool ret = (SwigDerivedClassHasMethod("initialize", swigMethodTypes2) ? touchvgPINVOKE.MgCmdDrawRect_initializeSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)) : touchvgPINVOKE.MgCmdDrawRect_initialize(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)));
    return ret;
  }

  public override bool backStep(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("backStep", swigMethodTypes3) ? touchvgPINVOKE.MgCmdDrawRect_backStepSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_backStep(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchBegan(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9) ? touchvgPINVOKE.MgCmdDrawRect_touchBeganSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_touchBegan(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchMoved(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10) ? touchvgPINVOKE.MgCmdDrawRect_touchMovedSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_touchMoved(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchEnded(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11) ? touchvgPINVOKE.MgCmdDrawRect_touchEndedSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCmdDrawRect_touchEnded(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  protected virtual void addRectShape(MgMotion sender) {
    if (SwigDerivedClassHasMethod("addRectShape", swigMethodTypes22)) touchvgPINVOKE.MgCmdDrawRect_addRectShapeSwigExplicitMgCmdDrawRect(swigCPtr, MgMotion.getCPtr(sender)); else touchvgPINVOKE.MgCmdDrawRect_addRectShape(swigCPtr, MgMotion.getCPtr(sender));
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("release", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgCmdDrawRect_0(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("cancel", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgCmdDrawRect_1(SwigDirectorcancel);
    if (SwigDerivedClassHasMethod("initialize", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgCmdDrawRect_2(SwigDirectorinitialize);
    if (SwigDerivedClassHasMethod("backStep", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgCmdDrawRect_3(SwigDirectorbackStep);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgCmdDrawRect_4(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgCmdDrawRect_5(SwigDirectorgatherShapes);
    if (SwigDerivedClassHasMethod("click", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgCmdDrawRect_6(SwigDirectorclick);
    if (SwigDerivedClassHasMethod("doubleClick", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgCmdDrawRect_7(SwigDirectordoubleClick);
    if (SwigDerivedClassHasMethod("longPress", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgCmdDrawRect_8(SwigDirectorlongPress);
    if (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgCmdDrawRect_9(SwigDirectortouchBegan);
    if (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgCmdDrawRect_10(SwigDirectortouchMoved);
    if (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgCmdDrawRect_11(SwigDirectortouchEnded);
    if (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgCmdDrawRect_12(SwigDirectormouseHover);
    if (SwigDerivedClassHasMethod("twoFingersMove", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgCmdDrawRect_13(SwigDirectortwoFingersMove);
    if (SwigDerivedClassHasMethod("isDrawingCommand", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgCmdDrawRect_14(SwigDirectorisDrawingCommand);
    if (SwigDerivedClassHasMethod("isFloatingCommand", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgCmdDrawRect_15(SwigDirectorisFloatingCommand);
    if (SwigDerivedClassHasMethod("doContextAction", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgCmdDrawRect_16(SwigDirectordoContextAction);
    if (SwigDerivedClassHasMethod("getShapeType", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgCmdDrawRect_17(SwigDirectorgetShapeType);
    if (SwigDerivedClassHasMethod("getMaxStep", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgCmdDrawRect_18(SwigDirectorgetMaxStep);
    if (SwigDerivedClassHasMethod("setStepPoint", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgCmdDrawRect_19(SwigDirectorsetStepPoint);
    if (SwigDerivedClassHasMethod("isStepPointAccepted", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateMgCmdDrawRect_20(SwigDirectorisStepPointAccepted);
    if (SwigDerivedClassHasMethod("snapOptionsForStep", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateMgCmdDrawRect_21(SwigDirectorsnapOptionsForStep);
    if (SwigDerivedClassHasMethod("addRectShape", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateMgCmdDrawRect_22(SwigDirectoraddRectShape);
    touchvgPINVOKE.MgCmdDrawRect_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgCmdDrawRect));
    return hasDerivedMethod;
  }

  private void SwigDirectorrelease() {
    release();
  }

  private bool SwigDirectorcancel(global::System.IntPtr sender) {
    return cancel((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorinitialize(global::System.IntPtr sender, global::System.IntPtr s) {
    return initialize((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (s == global::System.IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private bool SwigDirectorbackStep(global::System.IntPtr sender) {
    return backStep((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordraw(global::System.IntPtr sender, global::System.IntPtr gs) {
    return draw((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (gs == global::System.IntPtr.Zero) ? null : new GiGraphics(gs, false));
  }

  private bool SwigDirectorgatherShapes(global::System.IntPtr sender, global::System.IntPtr shapes) {
    return gatherShapes((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (shapes == global::System.IntPtr.Zero) ? null : new MgShapes(shapes, false));
  }

  private bool SwigDirectorclick(global::System.IntPtr sender) {
    return click((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordoubleClick(global::System.IntPtr sender) {
    return doubleClick((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorlongPress(global::System.IntPtr sender) {
    return longPress((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchBegan(global::System.IntPtr sender) {
    return touchBegan((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchMoved(global::System.IntPtr sender) {
    return touchMoved((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchEnded(global::System.IntPtr sender) {
    return touchEnded((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectormouseHover(global::System.IntPtr sender) {
    return mouseHover((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortwoFingersMove(global::System.IntPtr sender) {
    return twoFingersMove((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorisDrawingCommand() {
    return isDrawingCommand();
  }

  private bool SwigDirectorisFloatingCommand() {
    return isFloatingCommand();
  }

  private bool SwigDirectordoContextAction(global::System.IntPtr sender, int action) {
    return doContextAction((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), action);
  }

  private int SwigDirectorgetShapeType() {
    return getShapeType();
  }

  private int SwigDirectorgetMaxStep() {
    return getMaxStep();
  }

  private void SwigDirectorsetStepPoint(global::System.IntPtr sender, int step, global::System.IntPtr pt) {
    setStepPoint((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), step, new Point2d(pt, false));
  }

  private bool SwigDirectorisStepPointAccepted(global::System.IntPtr sender, global::System.IntPtr pt) {
    return isStepPointAccepted((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), new Point2d(pt, false));
  }

  private int SwigDirectorsnapOptionsForStep(global::System.IntPtr sender, int step) {
    return snapOptionsForStep((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), step);
  }

  private void SwigDirectoraddRectShape(global::System.IntPtr sender) {
    addRectShape((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  public delegate void SwigDelegateMgCmdDrawRect_0();
  public delegate bool SwigDelegateMgCmdDrawRect_1(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_2(global::System.IntPtr sender, global::System.IntPtr s);
  public delegate bool SwigDelegateMgCmdDrawRect_3(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_4(global::System.IntPtr sender, global::System.IntPtr gs);
  public delegate bool SwigDelegateMgCmdDrawRect_5(global::System.IntPtr sender, global::System.IntPtr shapes);
  public delegate bool SwigDelegateMgCmdDrawRect_6(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_7(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_8(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_9(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_10(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_11(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_12(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_13(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCmdDrawRect_14();
  public delegate bool SwigDelegateMgCmdDrawRect_15();
  public delegate bool SwigDelegateMgCmdDrawRect_16(global::System.IntPtr sender, int action);
  public delegate int SwigDelegateMgCmdDrawRect_17();
  public delegate int SwigDelegateMgCmdDrawRect_18();
  public delegate void SwigDelegateMgCmdDrawRect_19(global::System.IntPtr sender, int step, global::System.IntPtr pt);
  public delegate bool SwigDelegateMgCmdDrawRect_20(global::System.IntPtr sender, global::System.IntPtr pt);
  public delegate int SwigDelegateMgCmdDrawRect_21(global::System.IntPtr sender, int step);
  public delegate void SwigDelegateMgCmdDrawRect_22(global::System.IntPtr sender);

  private SwigDelegateMgCmdDrawRect_0 swigDelegate0;
  private SwigDelegateMgCmdDrawRect_1 swigDelegate1;
  private SwigDelegateMgCmdDrawRect_2 swigDelegate2;
  private SwigDelegateMgCmdDrawRect_3 swigDelegate3;
  private SwigDelegateMgCmdDrawRect_4 swigDelegate4;
  private SwigDelegateMgCmdDrawRect_5 swigDelegate5;
  private SwigDelegateMgCmdDrawRect_6 swigDelegate6;
  private SwigDelegateMgCmdDrawRect_7 swigDelegate7;
  private SwigDelegateMgCmdDrawRect_8 swigDelegate8;
  private SwigDelegateMgCmdDrawRect_9 swigDelegate9;
  private SwigDelegateMgCmdDrawRect_10 swigDelegate10;
  private SwigDelegateMgCmdDrawRect_11 swigDelegate11;
  private SwigDelegateMgCmdDrawRect_12 swigDelegate12;
  private SwigDelegateMgCmdDrawRect_13 swigDelegate13;
  private SwigDelegateMgCmdDrawRect_14 swigDelegate14;
  private SwigDelegateMgCmdDrawRect_15 swigDelegate15;
  private SwigDelegateMgCmdDrawRect_16 swigDelegate16;
  private SwigDelegateMgCmdDrawRect_17 swigDelegate17;
  private SwigDelegateMgCmdDrawRect_18 swigDelegate18;
  private SwigDelegateMgCmdDrawRect_19 swigDelegate19;
  private SwigDelegateMgCmdDrawRect_20 swigDelegate20;
  private SwigDelegateMgCmdDrawRect_21 swigDelegate21;
  private SwigDelegateMgCmdDrawRect_22 swigDelegate22;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(MgMotion), typeof(MgStorage) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(MgMotion), typeof(GiGraphics) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(MgMotion), typeof(MgShapes) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(MgMotion), typeof(int) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(MgMotion), typeof(int), typeof(Point2d) };
  private static global::System.Type[] swigMethodTypes20 = new global::System.Type[] { typeof(MgMotion), typeof(Point2d) };
  private static global::System.Type[] swigMethodTypes21 = new global::System.Type[] { typeof(MgMotion), typeof(int) };
  private static global::System.Type[] swigMethodTypes22 = new global::System.Type[] { typeof(MgMotion) };
}

}
