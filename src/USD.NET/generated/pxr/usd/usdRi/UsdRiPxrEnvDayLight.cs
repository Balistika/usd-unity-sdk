//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdRiPxrEnvDayLight : UsdLuxLight {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdRiPxrEnvDayLight(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdRiPxrEnvDayLight_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdRiPxrEnvDayLight obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdRiPxrEnvDayLight() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdRiPxrEnvDayLight(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdRiPxrEnvDayLight(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdRiPxrEnvDayLight__SWIG_0(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdRiPxrEnvDayLight() : this(UsdCsPINVOKE.new_UsdRiPxrEnvDayLight__SWIG_1(), true) {
  }

  public UsdRiPxrEnvDayLight(UsdSchemaBase schemaObj) : this(UsdCsPINVOKE.new_UsdRiPxrEnvDayLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetSchemaAttributeNames__SWIG_0(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetSchemaAttributeNames__SWIG_1(), false);
    return ret;
  }

  public new static UsdRiPxrEnvDayLight Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdRiPxrEnvDayLight ret = new UsdRiPxrEnvDayLight(UsdCsPINVOKE.UsdRiPxrEnvDayLight_Get(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdRiPxrEnvDayLight Define(UsdStageWeakPtr stage, SdfPath path) {
    UsdRiPxrEnvDayLight ret = new UsdRiPxrEnvDayLight(UsdCsPINVOKE.UsdRiPxrEnvDayLight_Define(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetDayAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetDayAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateDayAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateDayAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDayAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateDayAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateDayAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateDayAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetHazinessAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetHazinessAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateHazinessAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateHazinessAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHazinessAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateHazinessAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHazinessAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateHazinessAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetHourAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetHourAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateHourAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateHourAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHourAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateHourAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateHourAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateHourAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetLatitudeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetLatitudeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateLatitudeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateLatitudeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateLatitudeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateLatitudeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateLatitudeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateLatitudeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetLongitudeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetLongitudeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateLongitudeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateLongitudeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateLongitudeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateLongitudeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateLongitudeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateLongitudeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetMonthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetMonthAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateMonthAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateMonthAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateMonthAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateMonthAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateMonthAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateMonthAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetSkyTintAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetSkyTintAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateSkyTintAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSkyTintAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSkyTintAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSkyTintAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSkyTintAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSkyTintAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetSunDirectionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetSunDirectionAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateSunDirectionAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunDirectionAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSunDirectionAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunDirectionAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSunDirectionAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunDirectionAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetSunSizeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetSunSizeAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateSunSizeAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunSizeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSunSizeAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunSizeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSunSizeAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunSizeAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetSunTintAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetSunTintAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateSunTintAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunTintAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSunTintAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunTintAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateSunTintAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateSunTintAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetYearAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetYearAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateYearAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateYearAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateYearAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateYearAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateYearAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateYearAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetZoneAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_GetZoneAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateZoneAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateZoneAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateZoneAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateZoneAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateZoneAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdRiPxrEnvDayLight_CreateZoneAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

}

}