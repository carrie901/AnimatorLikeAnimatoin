﻿using UnityEngine;
using System.Collections;

public class Style5ControllerPlus : MonoBehaviour {

    int currentAnimation;
    [SerializeField] Style5AnimatorController target;
    [SerializeField] AnimationClip[] animations;

    void Start()
    {
        target.Setup(animations);
    }

    public void PlayNextAnimation()
    {
        currentAnimation++;
        if (currentAnimation >= animations.Length)
        {
            currentAnimation = 0;
        }
        var hash = target.GetAnimationStateHashFromClipsName(animations[currentAnimation].name);
        target.GetComponent<Animator>().CrossFadeInFixedTime(hash, 0.6f);
    }
}
