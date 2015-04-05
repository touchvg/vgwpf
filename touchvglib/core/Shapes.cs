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

public class Shapes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Shapes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Shapes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Shapes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_Shapes(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Shapes(int n) : this(touchvgPINVOKE.new_Shapes__SWIG_0(n), true) {
  }

  public Shapes() : this(touchvgPINVOKE.new_Shapes__SWIG_1(), true) {
  }

  public void setSize(int n) {
    touchvgPINVOKE.Shapes_setSize(swigCPtr, n);
  }

  public Shapes(MgShape v1, MgShape v2) : this(touchvgPINVOKE.new_Shapes__SWIG_2(MgShape.getCPtr(v1), MgShape.getCPtr(v2)), true) {
  }

  public Shapes(MgShape v1, MgShape v2, MgShape v3, MgShape v4) : this(touchvgPINVOKE.new_Shapes__SWIG_3(MgShape.getCPtr(v1), MgShape.getCPtr(v2), MgShape.getCPtr(v3), MgShape.getCPtr(v4)), true) {
  }

  public int count() {
    int ret = touchvgPINVOKE.Shapes_count(swigCPtr);
    return ret;
  }

  public MgShape get(int index) {
    global::System.IntPtr cPtr = touchvgPINVOKE.Shapes_get(swigCPtr, index);
    MgShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public void set(int index, MgShape value) {
    touchvgPINVOKE.Shapes_set__SWIG_0(swigCPtr, index, MgShape.getCPtr(value));
  }

  public void set(int index, MgShape v1, MgShape v2) {
    touchvgPINVOKE.Shapes_set__SWIG_1(swigCPtr, index, MgShape.getCPtr(v1), MgShape.getCPtr(v2));
  }

}

}
