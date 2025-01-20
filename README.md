# F# StackOverflowException in Recursive Factorial Function

This repository demonstrates a common error in F#: a StackOverflowException caused by incorrect handling of recursion in a factorial function. The `factorial` function, as initially written, lacks proper handling for negative input values, resulting in an infinite recursive call sequence.

The `bug.fs` file contains the erroneous code. The `bugSolution.fs` file shows the corrected version with appropriate error handling.