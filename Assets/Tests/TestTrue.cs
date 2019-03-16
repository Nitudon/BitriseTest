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
            EditorSceneManager.OpenScene("Assets/Scenes/BuildTest.unity");
            Assert.IsTrue(GameObject.Find("Test") != null);
        }
    }
}
