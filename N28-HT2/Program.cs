using N28_HT2.model;
using N28_HT2.Service;

var storageFile = new  ClonableList<StorageFile>();
storageFile.Add(new StorageFile() { Id = 1, Name = "file1.txt", Description = "This is file1.txt", Size = 100 });
storageFile.Add(new StorageFile() { Id = 2, Name = "file2.txt", Description = "This is file2.txt", Size = 200 });
storageFile.Add(new StorageFile() { Id = 3, Name = "file3.txt", Description = "This is file3.txt", Size = 300 });
storageFile.Add(new StorageFile() { Id = 4, Name = "file4.txt", Description = "This is file4.txt", Size = 400 });
var clone = storageFile.Clone();
Console.WriteLine("Original list");
Console.WriteLine(storageFile);
Console.WriteLine();
Console.WriteLine("Cloned list");
Console.WriteLine(clone);

// Change the element in the original list
storageFile[0].Name = "new_file1.txt";

Console.WriteLine("Original list after change:");
Console.WriteLine(storageFile);

