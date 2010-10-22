#region Usings

using NUnit.Framework;
using UnityEngine;


#endregion

public class TestsInPlugins : MonoBehaviour
{
    public bool runTests;


    private void Start()
    {
        if (runTests)
            NUnitLiteUnityRunner.RunTests();
    }
}

[TestFixture]
public class SomeTestInPlugins
{
    // NOTE: intentionally erroneous test
    [Test]
    public void CanCombineTestsWithAndOperator()
    {
        // NOTE: forced failure result
        Assert.That(42, Is.GreaterThan(40) & Is.LessThan(40));
    }
}
