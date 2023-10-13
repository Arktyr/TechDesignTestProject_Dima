using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeBase
{
    public class SceneLoader : MonoBehaviour
    {
        private const string _firstScene = "first_scene";
        private const string _secondScene = "second_scene";

        public void LoadFirstScene() =>
            SceneManager.LoadScene(_firstScene);

        public void LoadSecondScene() =>
            SceneManager.LoadScene(_secondScene);
    }
}