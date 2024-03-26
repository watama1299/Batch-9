// public class OneAndOnly
// {
//     // Public static instance
//     // Eager instantion => starts as null, only instantiated when first called
//     private static OneAndOnly oneAndOnlyInstance = null;
//     public static object obj = new();


//     // Private constructor
//     private OneAndOnly() {}

//     // Public instance getter
//     // Only way to access the instance
//     public OneAndOnly GetOneAndOnly() {
//         if (oneAndOnlyInstance is null) {
//             oneAndOnlyInstance = new();
//         }

//         return oneAndOnlyInstance;
//     }

//     // Thread safe version using locks
//     public OneAndOnly GetOneAndOnlySafe() {
//         if (oneAndOnlyInstance is null) {
//             lock (obj) {
//                 if (oneAndOnlyInstance is null) {
//                     oneAndOnlyInstance = new();
//                 }
//             }
//         }

//         return oneAndOnlyInstance;
//     }

//     public void DoSomething() {
//         Console.WriteLine("Do nothing");
//     }
// }