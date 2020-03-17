using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GMR.Animation.Animation
{
    public static class Animator
    {
        static List<Animation> animationList = new List<Animation>();
        public static int Count()
        {
            return animationList.Count;
        }

        private static Thread animationThread;
        private static double interval;
        public static bool isWork = false;
        public static void Start()
        {
            isWork = true;
            interval = 15;
            animationThread = new Thread(AnimationInvoker) { IsBackground = true, Name = "UI Animation" };

            animationThread.Start();
        }
        private static void AnimationInvoker()
        {
            while (true)
            {
                animationList.RemoveAll(a => a.Status == Animation.AnimationStatus.Completed);
                Parallel.For(0, Count(), index => { animationList[index].UpdateFrame(); });
                Thread.Sleep((int)interval);
            }
        }

        public static void Request(Animation anim, bool replaceIfExists)
        {
            anim.Status = Animation.AnimationStatus.Requested;

            Animation dupAnim = GetDuplicate(anim);

            if (dupAnim != null)
                if (replaceIfExists == true)
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                else return;
            animationList.Add(anim);
        }
        private static Animation GetDuplicate(Animation Anim)
        {
            return animationList.Find(a => a.ID == Anim.ID);
        }
    }
}
