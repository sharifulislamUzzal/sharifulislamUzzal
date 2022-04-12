using Task1;

var text = Console.ReadLine();

var frequencyCounter = new FrequencyCounter();
var result = frequencyCounter.Count(text);

Console.WriteLine(result);