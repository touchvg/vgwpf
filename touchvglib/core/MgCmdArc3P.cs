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

public class MgCmdArc3P : MgCommandDraw {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgCmdArc3P(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgCmdArc3P_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgCmdArc3P obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCmdArc3P() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCmdArc3P(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgCmdArc3P(string name) : this(touchvgPINVOKE.new_MgCmdArc3P__SWIG_0(name), true) {
  }

  public MgCmdArc3P() : this(touchvgPINVOKE.new_MgCmdArc3P__SWIG_1(), true) {
  }

  public override void release() {
    touchvgPINVOKE.MgCmdArc3P_release(swigCPtr);
  }

  public override bool touchBegan(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCmdArc3P_touchBegan(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public override bool touchMoved(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCmdArc3P_touchMoved(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public override bool touchEnded(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCmdArc3P_touchEnded(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public override bool initialize(MgMotion sender, MgStorage s) {
    bool ret = touchvgPINVOKE.MgCmdArc3P_initialize(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s));
    return ret;
  }

  public override bool draw(MgMotion sender, GiGraphics gs) {
    bool ret = touchvgPINVOKE.MgCmdArc3P_draw(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs));
    return ret;
  }

}

}
