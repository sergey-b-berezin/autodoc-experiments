# Page 2

This is another doc page

```csharp
Variable<bool> firstCoin = Variable.Bernoulli(0.5);
Variable<bool> secondCoin = Variable.Bernoulli(0.5);
Variable<bool> bothHeads = firstCoin & secondCoin;
InferenceEngine ie = new InferenceEngine();
Console.WriteLine("Probability both coins are heads: "+ie.Infer(bothHeads));
```
