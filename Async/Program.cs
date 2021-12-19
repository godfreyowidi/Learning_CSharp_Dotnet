using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

// async Task ReadFile()
// {
//     var lines = await File.ReadAllLinesAsync("textFile.txt");

//     foreach(var line in lines)
//     {
//         Console.WriteLine(line);
//     }
// }

// await ReadFile();

static async Task<int> GetDataFromNetworkASync()
{
    // Simulate a network call
    await Task.Delay(150);
    var result = 42;

    return result;
}

var networkResult = await GetDataFromNetworkASync();

Func<Task<int>> getDataFromNetworkViaLambda = async () =>
{
     await Task.Delay(150);
    var result = 42;

    return result;
};

// File.ReadAllLinesAsync("textFile.txt")
//     .ContinueWith( t => {

//         if (t.IsFaulted)
//         {
//             Console.Error.WriteLine(t.Exception);
//             return;
//         }

//         var lines = t.Result;
//         foreach(var line in lines)
//         {
//             Console.WriteLine(line);
//         }
//     });
// Console.ReadKey();
