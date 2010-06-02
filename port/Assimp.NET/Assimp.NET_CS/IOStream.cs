/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class IOStream : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IOStream(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IOStream obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IOStream() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_IOStream(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual uint Read(SWIGTYPE_p_void pvBuffer, uint pSize, uint pCount) {
    uint ret = Assimp_NETPINVOKE.IOStream_Read(swigCPtr, SWIGTYPE_p_void.getCPtr(pvBuffer), pSize, pCount);
    return ret;
  }

  public virtual uint Write(SWIGTYPE_p_void pvBuffer, uint pSize, uint pCount) {
    uint ret = Assimp_NETPINVOKE.IOStream_Write(swigCPtr, SWIGTYPE_p_void.getCPtr(pvBuffer), pSize, pCount);
    return ret;
  }

  public virtual aiReturn Seek(uint pOffset, aiOrigin pOrigin) {
    aiReturn ret = (aiReturn)Assimp_NETPINVOKE.IOStream_Seek(swigCPtr, pOffset, (int)pOrigin);
    return ret;
  }

  public virtual uint Tell() {
    uint ret = Assimp_NETPINVOKE.IOStream_Tell(swigCPtr);
    return ret;
  }

  public virtual uint FileSize() {
    uint ret = Assimp_NETPINVOKE.IOStream_FileSize(swigCPtr);
    return ret;
  }

  public virtual void Flush() {
    Assimp_NETPINVOKE.IOStream_Flush(swigCPtr);
  }

}