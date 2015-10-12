var velocidad=5.0;

function Update () {
var x:Vector3=Input.GetAxis("Horizontal")*transform.right*Time.deltaTime*velocidad;
var z:Vector3=Input.GetAxis("Vertical")*transform.forward*Time.deltaTime*velocidad;

transform.Traslate(x+z);

//transform.Translate(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

}