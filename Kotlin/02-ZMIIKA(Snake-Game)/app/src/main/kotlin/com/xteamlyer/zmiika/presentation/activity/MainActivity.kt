package com.xteamlyer.zmiika.presentation.activity

import androidx.compose.runtime.Composable
import androidx.navigation.NavHostController
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import com.xteamlyer.zmiika.domain.base.BaseActivity
import com.xteamlyer.zmiika.domain.navigation.Screen
import com.xteamlyer.zmiika.presentation.screen.AboutScreen
import com.xteamlyer.zmiika.presentation.screen.HighScoreScreen
import com.xteamlyer.zmiika.presentation.screen.MenuScreen
import com.xteamlyer.zmiika.presentation.screen.SettingScreen
import com.xteamlyer.zmiika.R
import android.media.MediaPlayer

class MainActivity : BaseActivity() {
    private lateinit var navController: NavHostController
    private var mediaPlayer: MediaPlayer? = null
    private var isAudioPlaying = false

    private fun startAudio() {
        if (mediaPlayer == null) {
            mediaPlayer = MediaPlayer.create(this, R.raw.music)
            mediaPlayer?.isLooping = true
            mediaPlayer?.start()
            isAudioPlaying = true
        }
    }

    private fun stopAudio() {
        mediaPlayer?.stop()
        mediaPlayer?.release()
        mediaPlayer = null
        isAudioPlaying = false
    }

    override fun onPause() {
        super.onPause()
        if (isAudioPlaying) {
            stopAudio()
        }
    }

    override fun onResume() {
        super.onResume()
        if (!isAudioPlaying) {
            startAudio()
        }
    }

    @Composable
    override fun Content() {
        navController = rememberNavController()
        SetupNavigation()
    }

    @Composable
    private fun SetupNavigation() {
        NavHost(navController = navController, startDestination = Screen.Menu.route) {
            composable(Screen.Menu.route) { MenuScreen(navController) }
            composable(Screen.HighScores.route) { HighScoreScreen(navController) }
            composable(Screen.Settings.route) { SettingScreen(navController) }
            composable(Screen.About.route) { AboutScreen(navController) }
        }
    }
}
