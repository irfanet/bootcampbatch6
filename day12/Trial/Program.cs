using System;
using System.Threading;

class UnmanagedResource : IDisposable {
    private IntPtr resourcePointer;
    private bool disposed = false;

    public UnmanagedResource() {
        resourcePointer = AllocateUnmanagedResource();
    }

    ~UnmanagedResource() {
        Dispose(false);
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) {
        if (disposed) {
            return;
        }

        if (disposing) {
            // No managed resources to dispose
        }

        FreeUnmanagedResource(resourcePointer);

        disposed = true;
    }

    private IntPtr AllocateUnmanagedResource() {
        // Kode untuk mengalokasikan sumber daya unmanaged
        return new IntPtr();
    }

    private void FreeUnmanagedResource(IntPtr ptr) {
        // Kode untuk membebaskan sumber daya unmanaged
    }
}

class ManagedResource : IDisposable {
    private bool disposed = false;

    public ManagedResource() {
        // Kode untuk mengalokasikan sumber daya managed
    }

    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing) {
        if (disposed) {
            return;
        }

        if (disposing) {
            // Kode untuk membebaskan sumber daya managed
        }

        disposed = true;
    }

    ~ManagedResource() {
        Dispose(false);
    }
}

class Program {
    static void Main() {
        // Penggunaan sumber daya unmanaged dengan Dispose pattern
        using (var resource1 = new UnmanagedResource()) {
            // Kode untuk menggunakan sumber daya unmanaged
        }

        // Penggunaan sumber daya managed dengan Dispose pattern
        using (var resource2 = new ManagedResource()) {
            // Kode untuk menggunakan sumber daya managed
        }

        // Penggunaan sumber daya unmanaged tanpa Dispose pattern
        var resource3 = new UnmanagedResource();
        // Kode untuk menggunakan sumber daya unmanaged
        resource3.Dispose();

        // Penggunaan sumber daya managed tanpa Dispose pattern
        var resource4 = new ManagedResource();
        // Kode untuk menggunakan sumber daya managed
        resource4.Dispose();

        Thread.Sleep(10000); // Menunggu selama 10 detik agar GC dapat bekerja

        // Membuat objek dan tidak memanggil Dispose atau Destructor
        var resource5 = new UnmanagedResource();
        // Kode untuk menggunakan sumber daya unmanaged
        resource5 = null;

        var resource6 = new ManagedResource();
        // Kode untuk menggunakan sumber daya managed
        resource6 = null;
    }
}
