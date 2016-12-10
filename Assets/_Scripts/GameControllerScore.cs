/* Source File Name: GameController
 * Author's Name: Ibrahim Natchee and Mamun Rahman
 * Last Modified By: Ibrahim Natchee
 * Date Modified Last: December 5th 2016
 * Program Description: this file is GameController cs file for the game
 * Revision History: December 5th 2016
 */

using UnityEngine;
using System.Collections;

// reference to the UI namespace
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// reference to manage my scenes
using UnityEngine.SceneManagement;


/**  
* <summary>  
* This is the GameController class to control the Game.  
* </summary>  
*   
* @class EnemyController  
*/
public class GameControllerScore : MonoBehaviour
{
    // PRIVATE INSTANCE VARIABLES ++++++++++++++++++
    private int _livesValue;
    private int _scoreValue;

    [Header("UI Objects")]
    public Text LivesLabel;
    public Text ScoreLabel;

    // PUBLIC PROPERTIES +++++++++++++++++++++++++++
    public int LivesValue
    {
        get
        {
            return this._livesValue;
        }

        set
        {
            this._livesValue = value;
            if (this._livesValue <= 0)
            {
                this.LivesLabel.text = "Lives: 0";
                SceneManager.LoadScene("GameOver");

            }
            else
            {
                this.LivesLabel.text = "Lives: " + this._livesValue;
            }
        }
    }

    public int ScoreValue
    {
        get
        {
            return this._scoreValue;
        }

        set
        {
            this._scoreValue = value;
            this.ScoreLabel.text = "Score: " + this._scoreValue;
        }
    }



    /**
        * <summary>
        * This is the method for starting the EnemyController class which initiates value
        * </summary>
        * 
        * @method Start
        * @returns {void} 
        */
    void Start()
    {
        this.LivesValue = 5;
        this.ScoreValue = 0;

    }

    /**
        * <summary>
        * This method is called once per frame.
        * </summary>
        * 
        * @method Update
        * @returns {void} 
        */
    void Update()
    {
    }


}