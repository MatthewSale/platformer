using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMovmentScript : MonoBehaviour
{
    // controlls variable
    PlayerControllsMain controlls;

    //movment varibales
    CharacterController C_controller;
    bool can_move_forward;
    bool can_move_left;
    bool can_move_right;
    bool can_move_back;    
    
    // camera variables
    float Camera_rotation = 0f;
    Vector2 rotate;
    public Transform camera;
    public Transform Player_modle;
    int Camera_Sensitivity = 3;

    //player speed variabels
    public int speed;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        controlls = new PlayerControllsMain();
        controlls.GamePlay.rotate.performed += context => rotate = context.ReadValue<Vector2>();
        controlls.GamePlay.rotate.canceled += context => rotate = Vector2.zero;
        controlls.GamePlay.ForwardMovement.performed += con => MoveForward();
        controlls.GamePlay.LeftMovement.performed += con => MoveLeft();
        controlls.GamePlay.RightMovement.performed += con => MoveRight();
        controlls.GamePlay.BackMovement.performed += con => MoveBack();
        controlls.GamePlay.ForwardMovement.canceled += con => DontMoveForward();
        controlls.GamePlay.LeftMovement.canceled += con => DontMoveLeft();
        controlls.GamePlay.RightMovement.canceled += con => DontMoveRight();
        controlls.GamePlay.BackMovement.canceled += con => DontMoveBack();                

        C_controller = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        //Forward Movement
        if (can_move_forward == true)
        {
            Vector3 alsoMove = transform.forward * speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
        //Left movement
        if (can_move_left == true)
        {
            Vector3 alsoMove = transform.right * -speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
        //Right movement
        if (can_move_right == true)
        {
            Vector3 alsoMove = transform.right * speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
        //back movement
        if (can_move_back == true)
        {
            Vector3 alsoMove = transform.forward * -speed;
            C_controller.Move(alsoMove * 1 * Time.deltaTime);
        }
                
        float yar = rotate.x;
        float pitch = rotate.y;
        Camera_rotation -= (pitch / Camera_Sensitivity);
        Camera_rotation = Mathf.Clamp(Camera_rotation, -90f, 90f);
        camera.localRotation = Quaternion.Euler(Camera_rotation, 0f, 0f);
        Player_modle.Rotate(Vector3.up * (yar / Camera_Sensitivity));       
    }

    void MoveForward()
    {
        Debug.Log("move forward");
        can_move_forward = true;
    }

    void DontMoveForward()
    {
        Debug.Log("mstop walking");
        can_move_forward = false;
    }

    void MoveLeft()
    {
        Debug.Log("moving left");
        can_move_left = true;
    }

    void DontMoveLeft()
    {
        Debug.Log("mstop walking");
        can_move_left = false;
    }

    void MoveRight()
    {
        Debug.Log("moving right");
        can_move_right = true;
    }

    void DontMoveRight()
    {
        Debug.Log("mstop walking");
        can_move_right = false;
    }

    void MoveBack()
    {
        Debug.Log("moving back");
        can_move_back = true;
    }

    void DontMoveBack()
    {
        Debug.Log("mstop walking");
        can_move_back = false;
    }

    private void OnEnable()
    {
        controlls.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controlls.GamePlay.Disable();
    }
}
