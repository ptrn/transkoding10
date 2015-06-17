## Krav til programvare ##

For Ubuntu 9.04:

```
# legg til støtte for de proprietære formater AAC, MP3 og h.264,
# forbedrede biblioteker for Vorbis og Theora,
# og installer ffmpeg
sudo apt-get install ffmpeg libavcodec-unstripped-52
```

_Les mer [her](http://ubuntuforums.org/showthread.php?t=1117283)_

## Kommandoer ##

| **Format** | **Kommando** | **Kommentar** |
|:-----------|:-------------|:--------------|
| MP4 _(h.264+AAC)_ | `ffmpeg -i FIL_INN -f mp4 -vcodec libx264 -b BITRATE_BILDE -acodec libfaac -ab BITRATE_LYD -ar 22050 -sameq FIL_UT.mp4` |               |
| Ogg _(Theora+Vorbis)_ | `ffmpeg2theora video.mkv -o out/out.ogv -V 1000` |               |
| MP3        | `ffmpeg -y -vn -i audio.mp3 -f mp3 -acodec libmp3lame -ac 1 -ab 128000 -ar 22050 out/out.mp3` |               |
| Ogg _(Vorbis)_ | `ffmpeg -y -vn -i audio.mp3 -f ogg -acodec libvorbis -ac 2 -ab 128000 -ar 22050 out/out.ogg` |               |
| FLAC       | `ffmpeg -y -i audio.mp3 -f wav tmp.wav`<br /> `flac tmp.wav -o out/out.flac -f`<br /> `rm tmp.wav` | må først konvertere til wav for å fjerne metadata, konverteres så til FLAC og sletter midlertidig fil |

### Forklaring ###

| **Parameter** | **Beskrivelse** |
|:--------------|:----------------|
| -vn           | uten video      |
| -r            | bilder/sekund   |
| -ab           | bithastighet for lyd, oppgis i bit/sekund |
| -b            | bithastighet for video, oppgis i bit/sekund |
| -ar           | samplingsfrekvens, gyldige verdier er:<br />`8000, 11025, 12000, 16000, 22050, 24000, 32000, 44100, 48000` |

## Mangler ##


  * lyd
    * frekvens
    * kvalitet
  * video
    * aspektratio
    * høyde
    * bredde
    * framerate