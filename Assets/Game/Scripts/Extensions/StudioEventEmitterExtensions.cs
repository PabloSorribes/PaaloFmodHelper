using UnityEngine;
using FMODUnity;

namespace Paalo.Fmod
{
	public static class StudioEventEmitterExtensions
	{
		/// <summary>
		/// Play this emitter if it isn't already playing (avoid multiple instances triggering in eg. Update()).
		/// </summary>
		/// <param name="eventEmitter"></param>
		public static void PlayIfNotPlaying(this StudioEventEmitter eventEmitter)
		{
			if (!eventEmitter.IsPlaying())
				eventEmitter.Play();
		}
	}
}
