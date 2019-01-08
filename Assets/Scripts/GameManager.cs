using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public Board mBoard;

    #region Second Video Variables
    public PieceManager mPieceManager;
    #endregion

    void Start()
    {
        // Create the board
        mBoard.Create();

        #region Second Video Functions
        // Create pieces
        mPieceManager.Setup(mBoard);
        #endregion
    }
}
