﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

namespace Adic.Tests {
    /// <summary>
    /// Tests for example 02 - Binding GameObjects.
    /// </summary>
    public class Example02BindingGameObjectsTest {
        [UnityTest]
        public IEnumerator TestBindings() {
            yield return new MonoBehaviourTest<GameObjectCheckTestBehaviour>();
        }

        public class GameObjectCheckTestBehaviour : BaseTestBehaviour {
            protected override void Init() {
                SceneManager.LoadScene("BindingGameObjects", LoadSceneMode.Additive);
            }

            protected override void Evaluate() {
                Assert.NotNull(GameObject.Find("Cube"));
                Assert.NotNull(GameObject.Find("GameObjectRotator"));
                LogAssert.NoUnexpectedReceived();
                isFinished = true;
            }
        }
    }
}