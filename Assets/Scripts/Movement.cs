using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    bool wait=true;

    int appleCount;
    public TMPro.TextMeshProUGUI AppleCountText;
    public TMPro.TextMeshProUGUI MoneyCountText;


    int money;
    void Update()
    {
        Vector3 moveDirection = Vector3.zero;


        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }


        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }


        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }


        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }

        if (moveDirection != Vector3.zero)
        {

            transform.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime, Space.World);


            Quaternion targetRotation = Quaternion.LookRotation(moveDirection, Vector3.up);


            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Apple") && AppleTree.Instance.state == 2 && wait)
        {
            wait = false;
            Invoke("Wait", 4);
            appleCount += 48;
            AppleCountText.text = "Apple:" + appleCount;
        }

        if (other.gameObject.CompareTag("Sell"))
        {
            money += appleCount;
            appleCount = 0;

            MoneyCountText.text = "Money:" + money;
            AppleCountText.text = "Apple:" + appleCount;

        }



    }

    void Wait()
    {
        wait = true;

    }



}
