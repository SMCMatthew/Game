using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    [Header("General")]
    public CharacterController controller;
    public Transform cam;
    [Space()]

    //[Header("Crouch")]
    //public Transform camOriginalPosition;
    //public Transform crouchingPoint;
    //public float crouchSpeed = 10f;
    //public float crouchedMovementSpeed = 7f;
    //public bool crouching;
    //[Space()]

    //[Header("Run")]
    //public float sprintSpeed = 16f;
    //public bool sprinting;
    //[Space()]

    [Header("Basic Stats")]
    //public float normalSpeed = 12f;
    public float speed = 12f;
    //public float jumpHeight = 3f;

    public float gravity = -9.81f;
    Vector3 velocity;
    //[Space()]

    //[Header("Jump")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    private void Awake()
    {
        
    }


    void Update()
    {
        //Jump
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 move = (transform.right * x + transform.forward * z).normalized;
        //Vector3 move = new Vector3(x, 0f, z).normalized;
        controller.Move(move * speed * Time.deltaTime);
        //if (Input.GetButtonDown("Jump") && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //Crouch
        //if(Input.GetKey(KeyCode.LeftControl))
        //{
        //    crouching = true;
        //    if (crouching)
        //    {
        //        cam.transform.position = Vector3.Lerp(cam.position, crouchingPoint.position, crouchSpeed * Time.deltaTime);
        //        controller.height = 1.3f;
        //        speed = crouchedMovementSpeed;
        //    }
        //}     
        //else
        //{
        //    crouching = false;
        //    cam.transform.position = Vector3.Lerp(cam.position, camOriginalPosition.position, crouchSpeed * Time.deltaTime);
        //    controller.height = 2.0f;
        //    speed = normalSpeed;
        //}

        //Sprint
        //if (Input.GetKey(KeyCode.LeftShift) && !crouching /*&& !isAiming*/)
        //{
        //    sprinting = true;
        //    if (sprinting)
        //    {
        //        speed = sprintSpeed;
        //        //rifleAnimator.SetBool("Running", true);
        //        //pistolAnimator.SetBool("Running", true);
        //        //shotgunAnimator.SetBool("Running", true);
        //        //cameraAnimator.SetBool("Running", true);
        //    }
        //}
        //else
        //{
        //    sprinting = false;
        //    //rifleAnimator.SetBool("Running", false);
        //    //pistolAnimator.SetBool("Running", false);
        //    //shotgunAnimator.SetBool("Running", false);
        //    //cameraAnimator.SetBool("Running", false);
        //}
    }
}
