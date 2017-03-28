using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	new Rigidbody2D  rigidbody2D;
	private static bool obiektIstnieje;
	public Vector2 speed = new Vector2(50, 50);
	private Vector2 movement;

	public Sprite Zolnierz_dol, Zolnierz_gora, Zolnierz_lewo, Zolnierz_prawo;

	public string startPoint;

	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();

		if (!obiektIstnieje) {
			obiektIstnieje = true;
			DontDestroyOnLoad (transform.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
		void Update()
		{
			float inputX = Input.GetAxis("Horizontal");
			float inputY = Input.GetAxis("Vertical");

			movement = new Vector2(
				speed.x * inputX,
				speed.y * inputY);


	if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			this.GetComponent<SpriteRenderer> ().sprite = Zolnierz_lewo;
	}
	if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			this.GetComponent<SpriteRenderer> ().sprite = Zolnierz_prawo;
	}
	if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			this.GetComponent<SpriteRenderer> ().sprite = Zolnierz_gora;
	}
	if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			this.GetComponent<SpriteRenderer> ().sprite = Zolnierz_dol;
	}


		}

		void FixedUpdate()
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 0.0f);
			rigidbody2D.velocity = movement;
		}
	}
