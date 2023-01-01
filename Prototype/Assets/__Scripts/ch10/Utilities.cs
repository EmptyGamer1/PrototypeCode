using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utilities
{
    public static int PlayerDeaths = 0;

    public static void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;

        Debug.Log($"Player deaths: {PlayerDeaths}");
        string deathMessage = UpdateDeathCount(ref PlayerDeaths);
        Debug.Log($"Player deaths: {PlayerDeaths}");
    }

    public static bool RestartLevel(int sceneIndex)
    {
        if(sceneIndex < 0)
        {
            throw new System.ArgumentException("Scene index cannot be negative");
        }

        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1.0f;
        return true;
    }

    public static string UpdateDeathCount(ref int countReference)
    {
        countReference += 1;
        return $"Next time you'll be at number {countReference}";
    }
}
