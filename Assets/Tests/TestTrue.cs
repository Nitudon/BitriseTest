using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestTrue
    {
        // A Test behaves as an ordinary method
        [Test]
        public void TestTrueSimplePasses()
        {
            EditorSceneManager.LoadScene(0);
            Assert.IsTrue(GameObject.Find("Test") != null);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestTrueWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
