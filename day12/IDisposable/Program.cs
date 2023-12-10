class MyClass : IDisposable {
    private bool disposed = false;
    
    // Method untuk membebaskan sumber daya unmanaged
    private void CleanupUnmanagedResources() {
        // Kode untuk membebaskan sumber daya unmanaged
    }
    
    // Method Dispose untuk membebaskan sumber daya
    public void Dispose() {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    protected virtual void Dispose(bool disposing) {
        if (disposed) {
            return;
        }
        
        if (disposing) {
            // Memanggil metode Dispose bagi objek yang memiliki referensi ke objek saat ini
        }
        
        CleanupUnmanagedResources();
        
        disposed = true;
    }
    
    ~MyClass() {
        Dispose(false);
    }
}

// Menggunakan objek MyClass
using (var obj = new MyClass()) {
    // Kode untuk menggunakan objek
}
