using System;

namespace Exam3
{
    /// <summary>
    /// Interface that defines a math subject contract.
    /// All student types implement this to return the math
    /// subject appropriate for their education level.
    /// </summary>
    public interface IMathClass
    {
        string Math();
    }
}
