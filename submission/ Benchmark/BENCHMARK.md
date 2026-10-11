# Benchmark: string vs StringBuilder

## BenchmarkDotNet Results

The benchmark compares two approaches for repeatedly appending the same text:

1. `StringConcatenation`
2. `StringBuilderConcatenation`

The benchmark was executed using BenchmarkDotNet.

### Environment

* BenchmarkDotNet: 0.15.8
* Operating System: Windows 11
* CPU: 12th Gen Intel Core i5-12450H 2.00GHz
* Physical Cores: 8
* Logical Cores: 12
* .NET SDK: 9.0.304
* Runtime: .NET 9.0.8
* Architecture: X64
* JIT: RyuJIT

These values are taken from the BenchmarkDotNet output generated on the machine used for this assignment.

---

## Results

| Method                     | Iterations |              Mean |             Error |            StdDev |         Allocated |
| -------------------------- | ---------: | ----------------: | ----------------: | ----------------: | ----------------: |
| StringConcatenation        |        100 |         30.048 us |         0.3493 us |         0.3096 us |         248.95 KB |
| StringBuilderConcatenation |        100 |          1.797 us |         0.0123 us |         0.0109 us |          13.54 KB |
| StringConcatenation        |      1,000 |      2,634.665 us |        19.8905 us |        17.6324 us |      24,462.82 KB |
| StringBuilderConcatenation |      1,000 |         14.579 us |         0.2899 us |         0.4065 us |         112.64 KB |
| StringConcatenation        |     10,000 |    495,478.360 us |     5,094.8887 us |     4,765.7621 us |   2,442,134.98 KB |
| StringBuilderConcatenation |     10,000 |        499.012 us |         3.7383 us |         3.4968 us |         991.61 KB |
| StringConcatenation        |    100,000 | 96,178,158.318 us | 2,236,144.9046 us | 5,929,939.4991 us | 244,154,461.24 KB |
| StringBuilderConcatenation |    100,000 |      6,068.773 us |       118.2572 us |       287.8544 us |       9,802.82 KB |

The table above is taken from the BenchmarkDotNet summary generated during the benchmark run.

---

## 1. Which approach was faster with 100 iterations?

With 100 iterations, `StringBuilderConcatenation` was faster.

* String concatenation: **30.048 us**
* StringBuilder: **1.797 us**

Therefore, StringBuilder had a much lower mean execution time in this benchmark.

---

## 2. Which approach was faster with 100,000 iterations?

With 100,000 iterations, `StringBuilderConcatenation` was faster.

* String concatenation: **96,178,158.318 us**
* StringBuilder: **6,068.773 us**

The difference became extremely large as the number of iterations increased.

---

## 3. Which approach allocated more memory?

`StringConcatenation` allocated much more memory than `StringBuilderConcatenation`.

At 100,000 iterations:

* String concatenation: **244,154,461.24 KB**
* StringBuilder: **9,802.82 KB**

This shows a very large difference in allocated memory for the benchmark used in this assignment.

---

## 4. What happened to string concatenation performance as the loop size increased?

The performance of normal string concatenation became significantly worse as the number of iterations increased.

The measured mean for string concatenation was:

* 100 iterations: **30.048 us**
* 1,000 iterations: **2,634.665 us**
* 10,000 iterations: **495,478.360 us**
* 100,000 iterations: **96,178,158.318 us**

The execution time increased dramatically as the loop size increased.

By comparison, StringBuilder increased much more gradually:

* 100 iterations: **1.797 us**
* 1,000 iterations: **14.579 us**
* 10,000 iterations: **499.012 us**
* 100,000 iterations: **6,068.773 us**

---

## 5. Why does repeated string concatenation create additional allocations?

A C# `string` is immutable. This means that after a string is created, its contents cannot be changed.

When repeatedly concatenating strings, a new string may need to be created to contain the new combined value. The previous string cannot simply be modified in place.

As the loop continues, this can result in many temporary string objects and additional memory allocations.

The benchmark results show this effect clearly. At 100,000 iterations, normal string concatenation allocated approximately **244 million KB**, while StringBuilder allocated approximately **9.8 million KB** in this benchmark.

---

## 6. Why does StringBuilder usually perform better when text is repeatedly appended?

`StringBuilder` is designed for scenarios where text needs to be modified repeatedly.

Instead of creating a new immutable string for every append operation, StringBuilder maintains an internal buffer that can grow as necessary.

This makes it more suitable for repeated appending, especially when the amount of text becomes large.

The benchmark results support this observation. For 100,000 iterations, StringBuilder had a mean of **6,068.773 us**, compared with **96,178,158.318 us** for normal string concatenation.

---

## 7. Is StringBuilder always better than normal string operations?

No.

StringBuilder is useful when text is being built or modified repeatedly, especially inside large loops.

However, this does not mean it should replace normal string operations everywhere.

For simple operations involving a small number of strings, normal string concatenation can be easier to read and may be completely appropriate.

The choice should depend on the situation:

* Use normal strings for simple and small string operations.
* Consider StringBuilder when repeatedly appending text, especially inside larger loops.
* Use benchmarking when performance is important and the actual workload is uncertain.

The results in this assignment show a strong performance and allocation advantage for StringBuilder in the tested repeated-append workload, but the benchmark represents this specific scenario rather than every possible string operation.

---

## Overall Observation

The benchmark showed that the difference between the two approaches became much larger as the number of iterations increased.

For 100 iterations:

* String concatenation: **30.048 us**
* StringBuilder: **1.797 us**

For 100,000 iterations:

* String concatenation: **96,178,158.318 us**
* StringBuilder: **6,068.773 us**

Memory allocation also increased substantially for normal string concatenation compared with StringBuilder.

Based on this benchmark, StringBuilder was the more suitable approach for the repeated string-appending workload tested in this assignment.

---

## Benchmark Conclusion

The experiment demonstrates why the choice between `string` and `StringBuilder` can matter when repeatedly building large amounts of text.

Normal string concatenation performed increasingly poorly as the iteration count increased and produced substantially more memory allocations in this benchmark.

StringBuilder maintained much lower execution times and allocations for the same repeated-appending workload.

The important lesson is not that StringBuilder should always be used, but that the appropriate approach depends on the operation being performed. Benchmarking the actual workload can help determine whether the difference is significant.
