using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.AI;


public class Move_Player : MonoBehaviour
{
    //для клави
    ///Rigidbody m_Rigidbody;
    ///public float m_Speed = 5f;
    
    //для мишкі
    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent myAgent;
    public Camera _CamerMian;

    void Start()
    {
      ///  m_Rigidbody = GetComponent<Rigidbody>();

        myAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveMouseClickCheck();
        }
    }

    private void MoveMouseClickCheck()
    {
        Ray myRay = _CamerMian.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
        {
            myAgent.SetDestination(hitInfo.point);
        }
    }

   /// void FixedUpdate()
    ///{
        ///Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        ///m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    ///}
    
    
}
