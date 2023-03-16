# VRC_AvatarAudioPlayer
Proposed component for avatars to be ables to play different clips from the same audioSource.

Canny post here:
https://feedback.vrchat.com/feature-requests/p/avatar-audio-player-component

Right now avatars must have an AudioSource component for each clips that they wanna play, even if they don't intend to play them simultaneously in the first place.
This exemple component would allow avatars to play different audioclips from the same source, while making sure only 1 clip can play simultaneously from that source.

This is setup to work similarly to how people play audio on their avatar right now,
instead of animating an audiosource to be enabled, you animate the index property of that component and enable it.


![Component](https://i.imgur.com/JOSTxXD.png)

