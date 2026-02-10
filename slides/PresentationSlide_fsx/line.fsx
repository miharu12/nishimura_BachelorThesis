//#############################################################################
// project title
let projectname = "line"
let version = "1.0.0"
//#############################################################################

let outputdir = @"C:\home\work"

#I @"..\bin\Debug\net9.0"
#r "docWriter.dll"

open System
open docWriter

fixedPage outputdir "line" 1920 1080 {Character=OFF; Subtitle=OFF; Voice=OFF} <| fun wr ->
    
    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.animation outputdir "line" {sX=700; sY=440; mX=160; mY=590; backgroundColor="#bbeeff"} p (100,590) <| fun (f,p) ->
                let line0 = f.animationLine Style[stroke.width 3.0; stroke.color "#ff4c4c"]
                f.seq {FrameTime=30; FrameNumber=1000} <| fun _ ->
                        line0.P {Start = {X = fun _ -> Dbl_e 200
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 400
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}

    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.animation outputdir "line" {sX=700; sY=440; mX=160; mY=590; backgroundColor="#bbeeff"} p (100,590) <| fun (f,p) ->
                let n = 100
                f.seq {FrameTime=60; FrameNumber=600} <| fun _ ->
                    for i in 0 .. (n-1) do
                        let lines1 = f.animationLine Style[stroke.width 3.0; stroke.color "#0033ff"]
                        lines1.P {
                            Start = {X = fun _ -> Dbl_e 10*i
                                     Y = fun t -> 200+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100)
                            }
                            End   = {X = fun _ -> Dbl_e 10*(i+1)
                                     Y = fun t -> 200+100*asm.sin(Dbl_e 0.1*(i+1)-2.0*Math.PI*t/100)
                            }
                        }

    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.animation outputdir "line" {sX=700; sY=440; mX=160; mY=590; backgroundColor="#bbeeff"} p (100,590) <| fun (f,p) ->
                let line0 = f.animationLine Style[stroke.width 3.0; stroke.color "#ff0000"]
                let line1 = f.animationLine Style[stroke.width 3.0; stroke.dash "1,3"; stroke.color "#008000"]
                let line2 = f.animationLine Style[stroke.width 3.0; stroke.dash "4,4"; stroke.color "#000000"]
                let line3 = f.animationLine Style[stroke.width 5.0; stroke.color "#000000"]

                f.seq {FrameTime=30; FrameNumber=1000} <| fun _ ->
                        line0.P {Start = {X = fun _ -> Dbl_e 60
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 160
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        line1.P {Start = {X = fun _ -> Dbl_e 220
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 320
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        line2.P {Start = {X = fun _ -> Dbl_e 380
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 480
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
                        line3.P {Start = {X = fun _ -> Dbl_e 540
                                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}
                                 End = {X = fun _ -> Dbl_e 640
                                        Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}
