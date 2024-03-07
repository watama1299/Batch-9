class Car : IDisposable
{
    private string? name;
    private int age;
    private FileStream? file;


    /**
        Instead of depending on GC.Collect(), we can use Dispose to immediately release resources
        If we wait for GC, we don't know when GC will come around and release the resources for us
        If we use Dispose, we can release the resources ourselves by setting null reference to the
        variables
    */
    
    // Keeps the dispose state of the class
    // to see whether Dispose has been called or not
    private bool disposedValue;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                name = null;
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
            file = null;
        }
    }

    // Finalizer used as safety net in case user forgets to call Dispose()
    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    ~Car()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);

        // Method ensures that GC ignores the finalizer method and sweeps it immediately
        // We can do this because all resources have been released in the Dispose method
        // so we don't need GC to do it for us.
        GC.SuppressFinalize(this);
    }
}