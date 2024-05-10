public class Reload : MonoBehaviour
{
        public int maxLives = 3;
        public Image[] hearts;
        public Sprite fullHeart;
        public Sprite emptyHeart;
        public Button someButton;
        public GameObject newHomeButton;

        private int currentLives;

        void Starat() 
        {
            currentLives = PlayerPrefs.GetInt("GameName_CurrentLives", maxLives);
            UpdateHearts();
        }

        private void UpdateHearts()
        {
            for (int i = 0; i < hearts.Length; i++)
            {
                if (i < currentLives)
                    hearts[i].sprite = fullHeart;
                else
                    hearts[i].sprite = emptyHeart;
            }

            if (currentLives <= 0)
            {
                someButton.interactable = false;
                newHomeButton.SetActive(true);
            }
                
        }

        //Into any GameOver / etc functions 
        
            currentLives--;
            PlayerPrefs.SetInt("MadSkyJump_CurrentLives", currentLives);
            UpdateHearts();

            if (currentLives <= 0)
            {
                PlayerPrefs.SetInt("MadSkyJump_CurrentLives", maxLives);
                currentLives = maxLives;
            }
        
            
}
