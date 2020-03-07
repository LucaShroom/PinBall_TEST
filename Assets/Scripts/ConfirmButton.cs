﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConfirmButton : MonoBehaviour{

  public PlayerSwatchScript finalSwatch;
  public RandomColourScript originalSwatch;
  public bool isOnColor;
  public byte minRedPass;
  public byte maxRedPass;
  public byte minGreenPass;
  public byte maxGreenPass;
  public byte minBluePass;
  public byte maxBluePass;
  public bool AnalysingAnswers;
  public TextMeshProUGUI percentageBox;
  public int difred;
  public int difgreen;
  public int difblue;
  public int finalScore;
  public bool isPlayer2;

/*
  public byte player1RValue;
  public byte player1GValue;
  public byte player1BValue;

  public byte rValue;
  public byte gValue;
  public byte bValue;
*/
    void Start(){

    }


    void Update(){
      /*
      minRedPass = originalSwatch.rValue;
      maxRedPass = originalSwatch.rValue;
      minRedPass -= 20;
      maxRedPass += 20;
      if (originalSwatch.rValue >= 235){
        maxRedPass = 255;
      }
      if (originalSwatch.rValue <= 20){
        minRedPass = 0;
      }

      minGreenPass = originalSwatch.gValue;
      maxGreenPass = originalSwatch.gValue;
      minGreenPass -= 20;
      maxGreenPass += 20;
      if (originalSwatch.gValue >= 235){
        maxGreenPass = 255;
      }
      if (originalSwatch.gValue <= 20){
        minGreenPass = 0;
      }

      minBluePass = originalSwatch.bValue;
      maxBluePass = originalSwatch.bValue;
      minBluePass -= 20;
      maxBluePass += 20;
      if (originalSwatch.bValue >= 235){
        maxBluePass = 255;
      }
      if (originalSwatch.bValue <= 20){
        minBluePass = 0;
      }
      */
      if(isPlayer2 == false){
        if(isOnColor && Input.GetKeyDown(KeyCode.E) && AnalysingAnswers == false){
          AnalysingAnswers = true;
          percentageBox.text =  finalScore.ToString() + "%";
          if(finalScore >= 95){
            Debug.Log("Super Shoot");
          }
          else if(finalScore >= 80){
            Debug.Log("Shoot");
          }

          /*
          if(finalSwatch.player1RValue >= minRedPass && finalSwatch.player1RValue <= maxRedPass){
            Debug.Log("Red Pass");
          }
          if(finalSwatch.player1GValue >= minGreenPass && finalSwatch.player1GValue <= maxGreenPass){
            Debug.Log("green Pass");
          }
          if(finalSwatch.player1BValue >= minBluePass && finalSwatch.player1BValue <= maxBluePass){
            Debug.Log("blue Pass");
          }
          */
          else{
            Debug.Log("fail");
          }
          AnalysingAnswers = false;
        }
      }

      if(isPlayer2 == true){
        if(isOnColor && Input.GetKeyDown(KeyCode.Keypad0) && AnalysingAnswers == false){
          AnalysingAnswers = true;
          percentageBox.text =  finalScore.ToString() + "%";
          if(finalScore >= 95){
            Debug.Log("P2 Super Shoot");
          }
          else if(finalScore >= 80){
            Debug.Log("P2 Shoot");
          }

          /*
          if(finalSwatch.player1RValue >= minRedPass && finalSwatch.player1RValue <= maxRedPass){
            Debug.Log("Red Pass");
          }
          if(finalSwatch.player1GValue >= minGreenPass && finalSwatch.player1GValue <= maxGreenPass){
            Debug.Log("green Pass");
          }
          if(finalSwatch.player1BValue >= minBluePass && finalSwatch.player1BValue <= maxBluePass){
            Debug.Log("blue Pass");
          }
          */
          else{
            Debug.Log("p2 fail");
          }
          AnalysingAnswers = false;
        }
      }

      difred = originalSwatch.rValue - finalSwatch.player1RValue;
      if(difred < 0){
        difred = -difred;
      }
      difgreen = originalSwatch.gValue - finalSwatch.player1GValue;
      if(difgreen < 0){
        difgreen = -difgreen;
      }
      difblue = originalSwatch.bValue - finalSwatch.player1BValue;
      if(difblue < 0){
        difblue = -difblue;
      }

      finalScore = 100 - ((difred + difgreen + difblue) / 3);
      if(finalScore < 0){
        finalScore = 0;
      }
    }

    void OnTriggerEnter2D (Collider2D col){
       isOnColor = true;
    }
    void OnTriggerExit2D (Collider2D col){
       isOnColor = false;
    }
}
