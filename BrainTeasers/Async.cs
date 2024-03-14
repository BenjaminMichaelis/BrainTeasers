namespace BrainTeasers;

public static class Async
{
    // change the code to pass the test that calls AsyncOperation
    private static async void DoAsyncProcess()
    {
        // simulate async operation
        await Task.Delay(1000);
        var result = 10;

        if (result != 42)
        {
            throw new Exception("AsyncVoid");
        }
    }

    public static async Task AsyncOperation()
    {
        await Task.Run(DoAsyncProcess);
    }

    public static async Task<byte[]> Compress(byte[] buffer)
    {
        using MemoryStream memoryStream = new();
        using System.IO.Compression.GZipStream gZipStream =
            new(
                memoryStream,
                    System.IO.Compression.CompressionMode.Compress);
        await gZipStream.WriteAsync(buffer.AsMemory(0, buffer.Length));

        return memoryStream.ToArray();
    }

    // change the code to pass the test that calls CompressFaster
    public static async Task<byte[]> CompressFaster(byte[] buffer)
    {
        using MemoryStream memoryStream = new();
        using System.IO.Compression.GZipStream gZipStream =
            new(
                memoryStream,
                    System.IO.Compression.CompressionMode.Compress);
        await gZipStream.WriteAsync(buffer.AsMemory(0, buffer.Length));

        return memoryStream.ToArray();
    }
}
