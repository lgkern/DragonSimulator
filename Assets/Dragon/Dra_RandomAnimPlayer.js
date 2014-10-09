#pragma strict

var anims:AnimationClip[];
private var rnd:float;
private var animName:String;
private var time:float;

function Start () {

rnd=Mathf.Round(Random.Range(0, anims.length));
}

function Update () {

animName=anims[rnd].name;
time+=Time.deltaTime;

if (!animation.IsPlaying(animName))
{
time=0;
animation.Play(animName);
}

if (time>anims[rnd].length)
{
rnd=Mathf.Round(Random.Range(0, anims.length));


}



}