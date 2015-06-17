# problemer #


## Konvertering fra MP4 (h.264+AAC) til MP3 ikke mulig, FFmpeg feiler ##

Sporing: [#10](http://code.google.com/p/transkoding10/issues/detail?id=10)

Status: ![http://transkoding10.googlecode.com/files/icon-ball-red.png](http://transkoding10.googlecode.com/files/icon-ball-red.png)

**feilmelding**
```
Error while opening codec for output stream #0.0 - maybe incorrect parameters such as bit_rate, rate, width or height
```

**parametere**
```
ffmpeg -i <FIL INN> -f mp3 -y <FIL UT>
```
å legge til parameteren `-vn` (ikke kod video) hjelper ikke.

Har prøvd å sette bitrate og samplingfrekvens manuelt, uten at det forander noe.



&lt;hr /&gt;



## Konvertering til Ogg Vorbis ikke mulig ##

Sporing: [#9](http://code.google.com/p/transkoding10/issues/detail?id=9)

Status: ![http://transkoding10.googlecode.com/files/icon-ball-green.png](http://transkoding10.googlecode.com/files/icon-ball-green.png)

**FFmpeg har støtte for koding av Ogg Vorbis**

### problemet ###

Det ser ut til at parameterene er hardkodet inn i klassen som definerer den nødvendige applikasjonen, ffmpeg2theora. Det er ikke støtte for koding til Vorbis i FFmpeg.

### stygg referanse ###

**F2TVideoConverterProcess.cs**, linje 46-53

```
    Path.ChangeExtension(fileName, 
    TheoraVideoFormat.Theora.OutputFileExtension);
if (useSimpleArguments)
    args = TheoraVideoFormat.Theora.GetSimpleArguments(
        fileName, outputFileName);
else
    args = TheoraVideoFormat.Theora.GetArguments(
        fileName, outputFileName);
```

### løsninger ###

  1. Undersøke mulighet for å inkorporere støtte av Vorbis i FFmpeg. Det er ikke ønskelig, ettersom det blir mer å vedlikeholde ved oppdateringer av FFmpeg.
  1. korrigere den stygge referansen i koden, og også melde ifra om det på utviklersiden til Miro- det vil være en god anledning for å komme i kontakt med utviklermiljøet til Miro
  1. skrive en ny klasse for konvertering til Vorbis ved bruk av ffmpeg2theora

### annet ###

Er det i det hele tatt mulig å bruke ffmpeg2theora for å konvertere til kun Vorbis, uten video? I dokumentasjonen listes parameteren `-vn`, som brukes for å ignorere videostrømmen, men fungerer det faktisk?