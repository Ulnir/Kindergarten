// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.UI)]
    [Tooltip("Sets the source image sprite of a UI Image component.")]
    public class SetSpriteByName : ComponentAction<UnityEngine.UI.Image>
    {
        [RequiredField]
        [CheckForComponent(typeof(UnityEngine.UI.Image))]
        [Tooltip("The GameObject with the Image UI component.")]
        public FsmOwnerDefault gameObject;

        [RequiredField]
        [Tooltip("The source sprite name.")]
        [ObjectType(typeof(string))]
        public FsmString Text;

        private FsmObject sprite;

        [Tooltip("Reset when exiting this state.")]
        public FsmBool resetOnExit;

        private UnityEngine.UI.Image image;
        private Sprite originalSprite;

        public override void Reset()
        {
            
            gameObject = null;
            resetOnExit = false;
        }

        public override void OnEnter()
        {
            
            sprite = Resources.Load(Text.Value) as Sprite;

            var go = Fsm.GetOwnerDefaultTarget(gameObject);
            if (UpdateCache(go))
            {
                image = cachedComponent;
            }

            originalSprite = image.sprite;

            DoSetImageSourceValue();

            Finish();
        }

        private void DoSetImageSourceValue()
        {
            if (image == null) return;

            image.sprite = sprite.Value as Sprite;
        }

        public override void OnExit()
        {
            if (image == null)
            {
                return;
            }

            if (resetOnExit.Value)
            {
                image.sprite = originalSprite;
            }
        }

    }
}