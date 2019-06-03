using System;
class hashTable
{
  static void Main ()
  {

    string[]hashed = new string[97];
    string name;
      string[] cities = new string[]
    {
    "Berlin", "London", "Rome", "Madrid", "Chicago", "Venice",
	"Warsow", "Paris", "Oslo", "New York", "Marsilia"};
    int hashVal;
    for (int i = 0; i < 11; i++)
      {
	name = cities[i];
	hashVal = SimpleHash (name, hashed);
	hashed[hashVal] = name;
      }
    PrintOut (hashed);
  }
  static int SimpleHash (string s, string[]arr)
  {
    int tot = 0;
    char[] cname;
    cname = s.ToCharArray ();
    for (int i = 0; i <= cname.GetUpperBound (0); i++)
      tot += (int) cname[i];
    return tot % arr.GetUpperBound (0);
  }
  static void PrintOut (string[]arr)
  {
    for (int i = 0; i <= arr.GetUpperBound (0); i++)
      if (arr[i] != null)
	Console.WriteLine (i + " " + arr[i]);
  }


}

// https://www.geeksforgeeks.org/hashing-set-1-introduction/
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=netframework-4.8






