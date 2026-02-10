//#############################################################################
// project title
let projectname = "PresentationSlide_nishimura"
let version = "1.0.0"
//#############################################################################

let outputdir = @"C:\home\work"

#I @"..\bin\Debug\net9.0"
#r "docWriter.dll"

open System
open docWriter

fixedPage outputdir "PresentationSlide_nishimura" 1920 1080 {Character=OFF; Subtitle=OFF; Voice=OFF} <| fun wr ->
    
    html.page //1ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\contents\008-scripts_台詞_D.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.title Style[] (p+position(100,350)) "数値解析用プログラミング言語と連動した"
            html.title Style[] (p+position(100,440)) "アニメーション図説フレームワークの開発"
            html.textA Style[] (p+position(1250,900)) "情報デザイン・コミュニケーション工学コース"
            html.textA Style[] (p+position(1250,950)) "数理波動システム研究室　　　西村　美春
"

    html.page //2ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "2"
            html.contents Style[] (p+position(50,50)) "研究背景"
            html.textA Style[] (p+position(100,150)) "数値解析プログラムのコードを流用して、プレゼンテーション資料を効率的に作成する"
            html.subtitle1 Style[] (p+position(80,250)) "既存のプレゼンテーションツール"
            html.subtitle1 Style[] (p+position(960,250)) "既存のアニメーションツール"
            html.subtitle2 Style[] (p+position(100,350)) "PowerPoint"
            html.subtitle2 Style[] (p+position(980,350)) "Manim"
            html.subtitle3 Style[] (p+position(980,650)) "問題点"
            html.textA Style[] (p+position(120,400)) "・正確な図の作成が困難"
            html.textA Style[] (p+position(120,450)) "・マウス操作でコンテンツの配置"
            html.textA Style[] (p+position(120,500)) "・同じようなコンテンツやアニメーションでも個別に"
            html.textA Style[] (p+position(120,550)) "　作成が必要（流用しにくい）"
            html.textA Style[] (p+position(1000,400)) "数式やグラフをアニメーションとして動画化"
            html.canvas Style[margin.left "120px"; margin.top "500px"; size.width "1750px"; size.height "500px"; area.backGroundColor "#ffffff"] <| fun () ->
                html.fig p <| fun (f,p)->
                    f.trianglearrow
                        <| Style[stroke.color "#000000";]
                        <| 10
                        <| position(1110,50)
                        <| position(1220,50)
                    f.trianglearrow
                        <| Style[stroke.color "#000000";]
                        <| 10
                        <| position(1420,50)
                        <| position(1540,50)
                    f.trianglearrow
                        <| Style[stroke.color "#000000";]
                        <| 10
                        <| position(1180,300)
                        <| position(1530,300)
                    f.line Style[stroke.width 3.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(1280,250) <| position(1430,350)
                    f.line Style[stroke.width 3.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(1280,350) <| position(1430,250)
                    f.line Style[stroke.width 1.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(1010,350) <| position(1010,470)
                    f.trianglearrow
                        <| Style[stroke.color "#000000";]
                        <| 10
                        <| position(1010,470)
                        <| position(1230,470)
                    f.trianglearrow
                        <| Style[stroke.color "#000000";]
                        <| 10
                        <| position(1400,470)
                        <| position(1530,470)
                html.textA Style[] (p+position(880,0)) "Pythonコード"
                html.textA Style[] (p+position(860,50)) "（数式・グラフ）"
                html.textA Style[] (p+position(1270,0)) "Manim"
                html.textA Style[] (p+position(1230,50)) "（アニメ化）"
                html.textA Style[] (p+position(1572,0)) "動画ファイル"
                html.textA Style[] (p+position(1572,50)) "（mp4など）"
                html.textA Style[] (p+position(880,250)) "数値解析プログラム"
                html.textC Style[] (p+position(880,300)) "30" "#ff0000" "　　C・Fortran"
                html.textA Style[] (p+position(1550,275)) "アニメーション"
                html.textA Style[] (p+position(1260,420)) "書き直し"
                html.textC Style[] (p+position(1260,470)) "30" "#ff0000" "python"
                html.textA Style[] (p+position(1550,445)) "アニメーション"
                html.image (Style[size.height "380px";], p+position(0,150)) @"C:\home\work\PresentationSlide_nishimura\PowerPoint１.png"

    //html.page //3ページ目
    //    [Tale, @"C:\home\contents\テール右斜AAA-.png";
    //     Dang, @"C:\home\contents\dango.png";]
    //    {Speaker = Tale;
    //     Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
    //     Subtitle = Serif ""}
    //    <| fun p ->
    //        html.textB Style[] (p+position(1860,10)) "3"
    //        html.contents Style[] (p+position(50,50)) "Pythonの課題"
    //        html.subtitle1 Style[] (p+position(80,150))  "Manim"
    //        html.textA Style[] (p+position(100,250))  "数式やグラフをアニメーションとして動画化"
    //        html.subtitle1 Style[] (p+position(80,700)) "Pythonでは不十分な理由"
    //        html.textA Style[] (p+position(100,800)) "インタープリタ言語のため実行が遅い"
    //        html.textC Style[] (p+position(550,800)) "30" "#ff0000" "遅い"
    //        html.textA Style[] (p+position(100,850)) "→複雑な図形や数式だと処理時間が膨大になる"
    //        html.canvas Style[margin.left "100px"; margin.top "350px"; size.width "1720px"; size.height "250px"; area.backGroundColor "#ffffff"] <| fun () ->
    //            html.fig p <| fun (f,p)->
    //                f.trianglearrow
    //                    <| Style[stroke.color "#000000";]
    //                    <| 10
    //                    <| position(390,124)
    //                    <| position(650,124)
    //                f.trianglearrow
    //                    <| Style[stroke.color "#000000";]
    //                    <| 10
    //                    <| position(1070,124)
    //                    <| position(1330,124)
    //            html.textB Style[] (p+position(40,70)) "Pythonコード"
    //            html.textB Style[] (p+position(10,120)) "（数式・グラフ）"
    //            html.textB Style[] (p+position(780,70)) "Manim"
    //            html.textB Style[] (p+position(720,120)) "（アニメ化）"
    //            html.textB Style[] (p+position(1410,70)) "動画ファイル"
    //            html.textB Style[] (p+position(1410,120)) "（mp4など）"

    html.page //3ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "3"
            html.contents Style[] (p+position(50,50)) "解決策"
            //html.textA Style[] (p+position(100,150)) "・実行速度の速い言語を使用"
            //html.textA Style[] (p+position(100,200)) "・Aqualis"
            //html.textA Style[] (p+position(100,250)) "　　→一つの言語で授業スライド作成可能"
            html.canvas Style[margin.left "100px"; margin.top "150px"; size.width "1720px"; size.height "880px"; area.backGroundColor "#ffffff"] <| fun () ->
                html.fig p <| fun (f,p)->
                    //f.line Style[stroke.width 1.0; stroke.color "#0033ff"; stroke.fill "#0033ff"] <| position(860,0) <| position(860,880)
                    //f.line Style[stroke.width 1.0; stroke.color "#0033ff"; stroke.fill "#0033ff"] <| position(0,440) <| position(1720,440)
                    //f.line Style[stroke.width 1.0; stroke.color "#0033ff"; stroke.fill "#0033ff"] <| position(430,0) <| position(430,880)
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(500,33)
                        <| position(620,33)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(500,162)
                        <| position(670,162)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(500,294)
                        <| position(620,294)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(400,426)
                        <| position(620,426)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(400,558)
                        <| position(620,558)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(400,690)
                        <| position(620,690)
                        <| 2
                    f.trianglearrow
                        <| Style[stroke.color "#ff0000"; stroke.fill "#ff0000"]
                        <| 5
                        <| position(400,812)
                        <| position(620,812)
                    f.linearrow
                        <| Style[stroke.color "#ff0000"; stroke.fill "#ff0000"]
                        <| position(400,812)
                        <| position(620,812)
                        <| 5
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(500,30) <| position(500,294)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(400,223) <| position(500,223)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(400,223) <| position(400,426)
                    f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "#ff0000"] <| position(150,426) <| position(400,426)
                    f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "#ff0000"] <| position(400,425) <| position(400,815)
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(810,30)
                        <| position(1150,30)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(1050,228)
                        <| position(1150,228)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(1050,492)
                        <| position(1150,492)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(780,690)
                        <| position(1150,690)
                        <| 2
                    f.trianglearrow
                        <| Style[stroke.color "#ff0000"; stroke.fill "#ff0000"]
                        <| 5
                        <| position(900,812)
                        <| position(1150,812)
                    f.linearrow
                        <| Style[stroke.color "#ff0000"; stroke.fill "#ff0000"]
                        <| position(900,812)
                        <| position(1150,812)
                        <| 5
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(1050,162) <| position(1050,294)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(760,162) <| position(1050,162)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(810,294) <| position(1050,294)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(1050,426) <| position(1050,558)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(800,426) <| position(1050,426)
                    f.line Style[stroke.width 2.0; stroke.color "#000000"; stroke.fill "#000000"] <| position(780,558) <| position(1050,558)
                html.textB Style[] (p+position(0,396)) "Aqualis"
                html.textB Style[] (p+position(660,0)) "Python"
                html.textB Style[] (p+position(700,132)) "C"
                html.textB Style[] (p+position(660,264)) "Fortran"
                html.textB Style[] (p+position(660,396)) "HTML"
                html.textB Style[] (p+position(660,528)) "Latex"
                html.textB Style[] (p+position(660,660)) "SVG"
                html.textC Style[] (p+position(660,762)) "40" "#ff0000" "HTML"
                html.textC Style[] (p+position(660,802)) "40" "#ff0000" "JavaScript"
                html.textB Style[] (p+position(1200,0)) "実行結果"
                html.textB Style[] (p+position(1200,198)) "数値解析"
                html.textB Style[] (p+position(1200,462)) "文書"
                html.textB Style[] (p+position(1200,660)) "図・グラフ"
                html.textC Style[] (p+position(1200,762)) "40" "#ff0000" "プレゼンテーション"
                html.textC Style[] (p+position(1160,802)) "40" "#ff0000" "（アニメーション、音声付き）"
                html.textB Style[] (p+position(220,363)) "変換"
                html.textC Style[] (p+position(660,213)) "30" "#ff0000" "実行が速い"

    html.page //4ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "4"
            html.contents Style[] (p+position(50,50)) "研究目的"
            html.subtitle1 Style[] (p+position(80,150)) "数値解析用プログラミング言語（Aqualis）と共通のコードでスライドを作成"
            html.subtitle2 Style[] (p+position(80,250)) "図形の描画"
            html.subtitle2 Style[] (p+position(960,250)) "波形などのアニメーションを簡単描画"
            html.animation outputdir "PresentationSlide_nishimura" {sX=800; sY=680; mX=1040; mY=350; backgroundColor="#bbeeff"} p (960,350) <| fun (f,p) ->
                let n = 400
                let lines = [|for i in 0 .. n -> f.animationLine Style[stroke.width 5.0; stroke.color "#ff4c4c"]|]
                f.seq {FrameTime=60; FrameNumber=600} <| fun _ ->
                    for i in 0 .. (n-1) do
                        lines[i].P {
                            Start = {
                                X = fun _ -> Dbl_e 10*i
                                Y = fun t -> 340+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100)
                            }
                            End = {
                                X = fun _ -> Dbl_e 10*(i+1)
                                Y = fun t -> 340+100*asm.sin(Dbl_e 0.1*(i+1)-2.0*Math.PI*t/100)
                            }
                        }
            html.canvas Style[margin.left "80px"; margin.top "350px"; size.width "800px"; size.height "680px"; area.backGroundColor "#bbeeff"] <| fun () ->
                html.fig p <| fun (f,p)->
                    f.Rect Style[stroke.width 1.0; stroke.color "#ff4c4c"; stroke.fill "#ff4c4c"] <| position(100,200) <| 100 <| 100
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(0,200)
                        <| position(100,200)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(100,200)
                        <| position(0,200)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(100,0)
                        <| position(100,200)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(100,200)
                        <| position(100,0)
                        <| 2
                    f.ellipse Style[stroke.width 1.0; stroke.color "#ff4c4c"; stroke.fill "#ff4c4c"] <| position(500,500) <| 140 <| 140
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(500,500)
                        <| position(640,500)
                        <| 2
                    f.linearrow
                        <| Style[stroke.color "#000000";]
                        <| position(640,500)
                        <| position(500,500)
                        <| 2
                html.textA Style[] (p+position(10,200)) "100px"
                html.textA Style[] (p+position(110,70)) "200px"
                html.textA Style[] (p+position(530,450)) "140px"
                html.textA Style[] (p+position(300,150)) "図形位置、大きさは数値で制御"

    html.page //5ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "5"
            html.contents Style[] (p+position(50,50)) "原理"
            html.subtitle1 Style[] (p+position(80,150)) "ファイル間の関係"
            html.image (Style[], p+position(100,200)) @"C:\home\work\PresentationSlide_nishimura\file_slid.svg"

    //html.page //5ページ目
    //    [Tale, @"C:\home\contents\テール右斜AAA-.png";
    //     Dang, @"C:\home\contents\dango.png";]
    //    {Speaker = Tale;
    //     Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
    //     Subtitle = Serif ""}
    //    <| fun p ->
    //        html.textB Style[] (p+position(1860,10)) "5"
    //        html.contents Style[] (p+position(50,50)) "原理"
    //        html.subtitle1 Style[] (p+position(80,150)) "ソースコード（アニメーション描画領域）"
    //        html.subtitle2 Style[] (p+position(100,250)) "Aqualis（ユーザが作成）"
    //        //html.textA Style[] (p+position(140,450)) "アニメーションを描画領域の"
    //        //html.textA Style[] (p+position(140,490)) "位置・サイズ・背景色を設定"
    //        html.subtitle2 Style[] (p+position(960,250)) "フレームワーク内の処理（ライブラリで定義済み）"
    //        html.subtitle2 Style[] (p+position(100,560)) "JavaScriptファイル（自動生成）"
    //        html.subtitle2 Style[] (p+position(960,560)) "HTMLファイル（自動生成）"
    //        //html.blockTextcode Style[] 
    //        //    <|(p+position(120,300))
    //        //    <|(860.0, 780.0)
    //        //    <| ["html.animation outputdir \"PresentationSlide_nishimura\""
    //        //        "   {sX=800; sY=580; mX=1040; mY=450; backgroundColor=\"#bbeeff\"}"
    //        //        "   p (960,450) <| fun (f,p) ->"]
    //        //    |> ignore
    //        html.blockTextcode Style[] 
    //            <|(p+position(980,300))
    //            <|(860.0, 780.0)
    //            <| ["static member animation (outputdir:string) (projectname:string) (s:ViewBoxStyle)"
    //                "                                           (p:position) (buttonX:int,buttonY:int) code ="
    //                "    figcounter <- figcounter + 1"
    //                "    let f = FigureAnimation(wrBody,wrJS,figcounter,outputdir,projectname,s.mX,s.mY,s.sX,s.sY)"]
    //            |> ignore
    //        html.blockTextcode Style[] 
    //            <|(p+position(120,610))
    //            <|(860.0, 600.0)
    //            <| ["function repeatSeq(fn, interval, Nt, onComplete){"
    //                "    let t = 0;"
    //                "    function run(){"
    //                "        if (t < Nt){"
    //                "            fn(t);"
    //                "            t++;"
    //                "            setTimeout(run, interval);}"
    //                "        else{onComplete();}"
    //                "    }"
    //                "    run();}"]
    //            |> ignore
    //        html.blockTextcode Style[] 
    //            <|(p+position(980,610))
    //            <|(860.0, 780.0)
    //            <| ["&ltsvg viewBox=\"0 0 \"+s.sX.ToString()+ +s.sY.ToString()+ "
    //                "width= +s.sX.ToString()+\"px\" "
    //                "heigth= +s.sY.ToString()+\"px\" "
    //                "mlns=\"http://www.w3.org/2000/svg\" "
    //                "style=\"margin-left: +s.mX.ToString()+;"
    //                "margin-top: +s.mY.ToString()+; "
    //                "osition: absolute;"
    //                "background-color: +s.backgroundColor+;"
    //                "\"&gt"
    //                "code(f,p)"
    //                "&lt/svg&gt"]
    //            |> ignore
    //        html.canvas Style[margin.left "0px"; margin.top "0px"; size.width "1920px"; size.height "1080px"; area.backGroundColor "#ffffff"] <| fun () ->
    //            html.fig p <| fun (f,p)->
    //                //f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "none"] <| position(166,340) <| position(270,340)
    //                f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "none"] <| position(1115,340) <| position(1219,340)
    //                f.linearrow
    //                    <| Style[stroke.color "#000000";]
    //                    <| position(800,400)
    //                    <| position(910,400)
    //                    <| 2
    //                f.linearrow
    //                    <| Style[stroke.color "#000000";]
    //                    <| position(910,450)
    //                    <| position(580,560)
    //                    <| 2
    //                f.linearrow
    //                    <| Style[stroke.color "#000000";]
    //                    <| position(1100,480)
    //                    <| position(1100,540)
    //                    <| 2
    //            html.image (Style[size.width "700px";], p+position(100,300)) @"C:\home\work\PresentationSlide_nishimura\Aqualiscode1.png"


    html.page //6ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "6"
            html.contents Style[] (p+position(50,50)) "アニメーション制御の実装"
            html.subtitle1 Style[] (p+position(80,150)) "図形の描画"
            //html.subtitle2 Style[] (p+position(100,250)) "ボタンを画面に表示（HTMLファイル）"
            //html.subtitle2 Style[] (p+position(100,650)) "ボタン押下時の処理（JavaScriptファイル）"
            //html.textC Style[] (p+position(100,970)) "40" "#ff0000" "アニメーション描画領域作成時に自動生成"
            //html.subtitle2 Style[] (p+position(1320,250)) "ボタン動作"
            //html.textA Style[] (p+position(980,300)) "startボタン押下："
            //html.textC Style[] (p+position(1220,300)) "30" "#ff0000" "非表示"
            //html.textA Style[] (p+position(1310,300)) "（hidden）"
            //html.textA Style[] (p+position(1450,300)) "→"
            //html.textC Style[] (p+position(1530,300)) "30" "#ff0000" "表示"
            //html.textA Style[] (p+position(1590,300)) "（visible）"
            //html.textA Style[] (p+position(980,350)) "resetボタン押下："
            //html.textC Style[] (p+position(1230,350)) "30" "#ff0000" "表示"
            //html.textA Style[] (p+position(1280,350)) "（visible）"
            //html.textA Style[] (p+position(1450,350)) "→"
            //html.textC Style[] (p+position(1530,350)) "30" "#ff0000" "非表示"
            //html.textA Style[] (p+position(1620,350)) "（hidden）"
            //html.blockTextcode Style[] 
            //    <|(p+position(120,300))
            //    <|(800.0, 100.0)
            //    <| ["&lt/div&gt"
            //        "&ltbutton id = \"startButtonstart0\""
            //        "        onclick = \"animationStartMap['start0']()\""
            //        "        style = \"position: absolute; margin-left: 960px; margin-top: 450px;"
            //        "                                                            z-index: 1000;\" &gt"
            //        "Start"
            //        "&lt/button&gt"
            //        "&lt/div&gt"]
            //    |> ignore
            html.canvas Style[margin.left "0px"; margin.top "0px"; size.width "1920px"; size.height "1080px"; area.backGroundColor "#ffffff"] <| fun () ->
                html.fig p <| fun (f,p)->
                    f.Rect Style[stroke.width 1.0; stroke.color "#bbeeff"; stroke.fill "#bbeeff"] <| position(1320,280) <| 520 <| 580
                    f.ellipse Style[stroke.width 1.0; stroke.color "#ff4c4c"; stroke.fill "#ff4c4c"] <| position(1580,570) <| 100 <| 100
                html.image (Style[], p+position(100,200)) @"C:\home\work\PresentationSlide_nishimura\shape.svg"
                //html.image (Style[size.width "700px";], p+position(0,0)) @"C:\home\work\PresentationSlide_nishimura\time.png"


    html.page //7ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "7"
            html.contents Style[] (p+position(50,50)) "アニメーション制御の実装"
            html.subtitle1 Style[] (p+position(80,150)) "アニメーション処理（例：直線）"
            //html.subtitle2 Style[] (p+position(100,250)) "Aqualis（ユーザが作成）"
            //html.subtitle2 Style[] (p+position(960,250)) "HTMLファイル（自動生成）"
            //html.subtitle2 Style[] (p+position(960,380)) "JavaScriptファイル（自動生成）"
            html.animation outputdir "PresentationSlide_nishimura" {sX=420; sY=580; mX=1400; mY=280; backgroundColor="#bbeeff"} p (1320,280) <| fun (f,p) ->
                let line0 = f.animationLine Style[stroke.width 3.0; stroke.color "#ff4c4c"]
                f.seq {FrameTime=30; FrameNumber=1000} <| fun _ ->
                        line0.P {
                            Start = {
                                X = fun _ -> Dbl_e 100
                                Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)
                            }
                            End = {
                                X = fun _ -> Dbl_e 300
                                Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)
                            }
                        }
            html.image (Style[], p+position(100,200)) @"C:\home\work\PresentationSlide_nishimura\line_code.svg"
            //html.blockTextcode Style[] 
            //    <|(p+position(120,300))
            //    <|(860.0, 780.0)
            //    <| [
            //        "let line0 = f.animationLine Style[stroke.width 3.0; stroke.color \"#ff4c4c\"]"
            //        "f.seq {FrameTime=30; FrameNumber=1000} <| fun _ ->"
            //        "        line0.P {Start = {X = fun _ -> Dbl_e 200"
            //        "                          Y = fun t -> 240+100*asm.sin(-2.0*Math.PI*t/100)}"
            //        "                 End   = {X = fun _ -> Dbl_e 400"
            //        "                          Y = fun t -> 240+100*asm.sin(2.0*Math.PI*t/100)}}"
            //    ]
            //    |> ignore
            //html.blockTextcode Style[] 
            //    <|(p+position(980,300))
            //    <|(960.0, 400.0)
            //    <| ["&ltline id = \"contentsID0\" style = \"visibility: hidden; stroke-width: 3px; stroke: #ff4c4c;\"/&gt"]
            //    |> ignore
            //html.blockTextcode Style[] 
            //    <|(p+position(980,430))
            //    <|(860.0, 780.0)
            //    <| ["const animationStartMap = {start0: () => {repeatSeq(animationSeqID0, 30, 1000, () => {});},"
            //        "                           test: () => {}};"
            //        ""
            //        "function repeatSeq(fn, interval, Nt, onComplete){"
            //        "コード省略　　一定間隔でtを増やしながらfn(t)を呼び出す"
            //        "          }"
            //        "function animationSeqID0(t){"
            //        "    var e = document.getElementById(\"contentsID0\");"
            //        "    var x1 = 200;"
            //        "    var y1 = 440-(240+100*Math.sin(-6.283185307179586*t/100));"
            //        "    var x2 = 400;"
            //        "    var y2 = 440-(240+100*Math.sin(6.283185307179586*t/100));"
            //        "    e.setAttribute(\"style\",\"visibility: visible; stroke-width: 3px; stroke: #ff4c4c;\");"
            //        "コード省略　　計算結果をSVGの属性に反映"
            //        "}"
            //    ]
            //    |> ignore

            //html.canvas Style[margin.left "120px"; margin.top "300px"; size.width "950px"; size.height "750px"; area.backGroundColor "#ffffff"] <| fun () ->
            //    html.image (Style[size.height "250px";], p+position(0,0)) @"C:\home\work\PresentationSlide_nishimura\aqualisLine.png"

            //html.canvas Style[margin.left "0px"; margin.top "0px"; size.width "1920px"; size.height "1080px"; area.backGroundColor "#ffffff"] <| fun () ->
            //    html.fig p <| fun (f,p)->
            //        f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "none"] <| position(1448,460) <| position(1462,460)
            //        f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "none"] <| position(1548,500) <| position(1562,500)
            //        f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "none"] <| position(1428,540) <| position(1442,540)
            //        f.line Style[stroke.width 5.0; stroke.color "#ff0000"; stroke.fill "none"] <| position(1528,580) <| position(1542,580)



    html.page //8ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "8"
            html.contents Style[] (p+position(50,50)) "アニメーション制御の実装"
            html.subtitle1 Style[] (p+position(80,150)) "波形のアニメーション"
            html.textC Style[] (p+position(1270,400)) "30" "#0033ff" "line1"
            html.textC Style[] (p+position(1270,730)) "30" "#006400" "line2"
            //html.subtitle2 Style[] (p+position(100,250)) "アニメーション描画領域の設定"
            //html.subtitle2 Style[] (p+position(100,480)) "描画スタイル等の指定"
            //html.subtitle2 Style[] (p+position(100,710)) "波形の描画"
            html.animation outputdir "PresentationSlide_nishimura" {sX=520; sY=680; mX=1350; mY=280; backgroundColor="#bbeeff"} p (1270,280) <| fun (f,p) ->
                let step = 5
                let n = 100
                f.seq {FrameTime=60; FrameNumber=600} <| fun _ ->
                    for i in 0 .. (n-1) do
                        let lines1 = f.animationLine Style[stroke.width 3.0; stroke.color "#0033ff"]
                        let lines2 = f.animationLine Style[stroke.width 8.0; stroke.color "#006400"]
                        lines1.P {
                            Start = {
                                X = fun _ -> Dbl_e 10*i
                                Y = fun t -> 500+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100)
                            }
                            End = {
                                X = fun _ -> Dbl_e 10*(i+1)
                                Y = fun t -> 500+100*asm.sin(Dbl_e 0.1*(i+1)-2.0*Math.PI*t/100)
                            }
                        }
                        lines2.P {
                            Start = {
                                X = fun _ -> Dbl_e 10*i
                                Y = fun t -> 200+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100)
                            }
                            End = {
                                X = fun _ -> Dbl_e 10*(i+1)
                                Y = fun t -> 200+100*asm.sin(Dbl_e 0.1*(i+1)-2.0*Math.PI*t/100)
                            }
                        }
            html.image (Style[], p+position(50,200)) @"C:\home\work\PresentationSlide_nishimura\let_n.svg"


    html.page //9ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1860,10)) "9"
            html.contents Style[] (p+position(50,50)) "アニメーション制御の実装"
            html.subtitle1 Style[] (p+position(80,150)) "図形のアニメーション"
            html.subtitle2 Style[] (p+position(100,250)) "Aqualis（ユーザが作成）"
            html.subtitle2 Style[] (p+position(100,650)) "アニメーションの実行順序（JavaScriptファイル）"
            //html.subtitle2 Style[] (p+position(100,520)) "破線描画"
            //html.subtitle2 Style[] (p+position(100,750)) "円弧描画"
            html.animation outputdir "PresentationSlide_nishimura" {sX=700; sY=780; mX=1140; mY=250; backgroundColor="#bbeeff"} p (1080,250) <| fun (f,p) ->
                let line1 = f.animationLine Style[stroke.width 4.0; stroke.dash "4,4"; stroke.color "#ff69b4"]
                let elps1 = f.animationArc Style[stroke.width 6.0; stroke.color "#006400"; stroke.fill "none";]
                /// 中心座標
                let cx,cy = I 350, I 390
                let constCenter = { X = (fun _ -> cx); Y = fun _ -> cy }
                /// 円弧の半径
                let R = D 198.0
                // 中心から右に破線描画
                f.seq {FrameTime=6; FrameNumber=500} <| fun s ->
                    line1.P {
                        Start = constCenter
                        End = {
                            X = fun t -> cx + R*t/(s.FrameNumber-1)
                            Y = fun _ -> cy }}
                f.seq {FrameTime=6; FrameNumber=100} <| fun s ->
                    elps1.P {
                        center = constCenter
                        angle1 = fun _ -> I 0
                        angle2 = fun t -> 360*t/(s.FrameNumber-1)
                        radius = fun _ -> R }
            html.canvas Style[margin.left "120px"; margin.top "320px"; size.width "950px"; size.height "750px"; area.backGroundColor "#ffffff"] <| fun () ->
                html.image (Style[], p+position(0,0)) @"C:\home\work\PresentationSlide_nishimura\line_arc.svg"
                html.image (Style[], p+position(0,90)) @"C:\home\work\PresentationSlide_nishimura\line_arc_js.svg"
            //    html.image (Style[size.width "800px";], p+position(0,0)) @"C:\home\work\PresentationSlide_nishimura\lin_arc.png"
            //    html.image (Style[size.width "800px";], p+position(0,90)) @"C:\home\work\PresentationSlide_nishimura\repeatSeq.png"
                //html.blockTextcode Style[] 
                //    <| (p+position(0,0))
                //    <| (860.0, 780.0)
                //    <| ["f.seq {FrameTime=6; FrameNumber=100} <| fun s ->"
                //        "    line1.P {Start = constCenter"
                //        "             End = {X = fun t -> cx + R*t/(s.FrameNumber-1)"
                //        "                    Y = fun _ -> cy }}"
                //        "f.seq {FrameTime=6; FrameNumber=100} <| fun s ->"
                //        "    elps1.P {center = constCenter"
                //        "             angle1 = fun _ -> I 0"
                //        "             angle2 = fun t -> 360*t/(s.FrameNumber-1)"
                //        "             radius = fun _ -> R }"]
                //    |> ignore

//    html.page //12ページ目
//        [Tale, @"C:\home\contents\テール右斜AAA-.png";
//         Dang, @"C:\home\contents\dango.png";]
//        {Speaker = Tale;
//         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
//         Subtitle = Serif ""}
//        <| fun p ->
//            html.contents Style[] (p+position(50,50)) "図形・テキスト・画像のアニメーション制御"
//            html.subtitle1 Style[] (p+position(80,150)) "テキストのアニメーション"
//            html.subtitle1 Style[] (p+position(80,700)) "画像のアニメーション"

    html.page //10ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\contents\0076-scripts_台詞_T.wav"
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1840,10)) "10"
            html.contents Style[] (p+position(50,50)) "繰り返し処理で大量のアニメーションを表示する例"
            html.subtitle2 Style[] (p+position(910,150)) "ソースコード"
            html.animation outputdir "PresentationSlide_nishimura" {sX=700; sY=880; mX=160; mY=150; backgroundColor="#bbeeff"} p (100,150) <| fun (f,p) ->
                let n = 40
                let m = 10
                let pointR = I 5
                f.seq {FrameTime=60; FrameNumber=900} <| fun _ ->
                    for j in 0 .. (m-1) do
                        for i in 0 .. (n-1) do
                            let elps0 = f.animationEllipse Style[stroke.width 3.0; stroke.color "#0000ff"; stroke.fill "#0000ff";]
                            elps0.P {
                                center = { X = (fun _ -> Dbl_e 10+20*i );
                                           Y = fun t -> 0+100*j+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100)}
                                radiusX = fun _ -> pointR
                                radiusY = fun _ -> pointR}
            html.canvas Style[margin.left "910px"; margin.top "220px"; size.width "900px"; size.height "780px"; area.backGroundColor "#ffffff"] <| fun () ->
                html.image (Style[], p+position(0,0)) @"C:\home\work\PresentationSlide_nishimura\let_n_m.svg"
            //html.blockTextcode Style[] 
            //    <|(p+position(980,250))
            //    <|(800.0, 780.0)
            //    <| ["let n = 40"
            //        "let m = 10"
            //        "let pointR = I 5"
            //        "f.seq {FrameTime=60; FrameNumber=900} <| fun _ ->"
            //        "    for j in 0 .. (m-1) do"
            //        "        let elps0 ="
            //        "            [|for i in 0 .. n -> f.animationEllipse"
            //        "              Style[stroke.width 3.0; stroke.color \"#0000ff\"; stroke.fill \"#0000ff\";]|]"
            //        "        for i in 0 .. (n-1) do"
            //        "            elps0[i].P {"
            //        "                center = { X = (fun _ -> Dbl_e 10+20*i );"
            //        "                           Y = fun t -> 0+100*j+100*asm.sin(Dbl_e i*0.1-2.0*Math.PI*t/100) }"
            //        "                radiusX = fun _ -> pointR"
            //        "                radiusY = fun _ -> pointR}"
            //    ]
            //    |> ignore

    html.page //11ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile ""
         Subtitle = Serif ""}
        <| fun p ->
            html.textB Style[] (p+position(1840,10)) "11"
            html.contents Style[] (p+position(350,50)) "まとめ"
            html.subtitle1 Style[] (p+position(380,150)) "目的"
            html.textA Style[] (p+position(400,250)) "・数値解析プログラムのコードを流用して、プレゼンテーション資料を効率的に作成する"
            html.textA Style[] (p+position(400,300)) "　→図形位置、大きさを数値で制御"
            html.textA Style[] (p+position(400,350)) "　→波形などのアニメーションを簡単描画"
            html.subtitle1 Style[] (p+position(380,450)) "研究内容"
            html.textA Style[] (p+position(400,550)) "Aqualisのコード→HTML・JavaScriptのコードを生成するライブラリ（関数群）を実装"
            html.subtitle1 Style[] (p+position(380,650)) "結果"
            html.textA Style[] (p+position(400,750)) "数値解析用プログラミング言語（Aqualis）と共通のコードでスライドも作れる"
            html.textA Style[] (p+position(400,800)) "正確な図・アニメーションを効率的に作成可能"

    html.page //12ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Tale;
         Source = AudioFile @"C:\home\work\PresentationSlide_nishimura\0-中間発表D01\0-中間発表T01.wav"
         Subtitle = Serif "こんなふうに、音声も流せるんですよね。"}
        <| fun p ->
            html.textB Style[] (p+position(1840,10)) "12"
            html.contents Style[] (p+position(350,50)) "まとめ"
            html.subtitle1 Style[] (p+position(380,150)) "目的"
            html.textA Style[] (p+position(400,250)) "・数値解析プログラムのコードを流用して、プレゼンテーション資料を効率的に作成する"
            html.textA Style[] (p+position(400,300)) "　→図形位置、大きさを数値で制御"
            html.textA Style[] (p+position(400,350)) "　→波形などのアニメーションを簡単描画"
            html.subtitle1 Style[] (p+position(380,450)) "研究内容"
            html.textA Style[] (p+position(400,550)) "Aqualisのコード→HTML・JavaScriptのコードを生成するライブラリ（関数群）を実装"
            html.subtitle1 Style[] (p+position(380,650)) "結果"
            html.textA Style[] (p+position(400,750)) "数値解析用プログラミング言語（Aqualis）と共通のコードでスライドも作れる"
            html.textA Style[] (p+position(400,800)) "正確な図・アニメーションを効率的に作成可能"

    html.page //12ページ目
        [Tale, @"C:\home\contents\テール右斜AAA-.png";
         Dang, @"C:\home\contents\dango.png";]
        {Speaker = Dang;
         Source = AudioFile @"C:\home\work\PresentationSlide_nishimura\0-中間発表D01\0-中間発表D01.wav"
         Subtitle = Serif "ってことはさ、オンデマンド教材にも使えるってこと？"}
        <| fun p ->
            html.textB Style[] (p+position(1840,10)) "13"
            html.contents Style[] (p+position(350,50)) "まとめ"
            html.subtitle1 Style[] (p+position(380,150)) "目的"
            html.textA Style[] (p+position(400,250)) "・数値解析プログラムのコードを流用して、プレゼンテーション資料を効率的に作成する"
            html.textA Style[] (p+position(400,300)) "　→図形位置、大きさを数値で制御"
            html.textA Style[] (p+position(400,350)) "　→波形などのアニメーションを簡単描画"
            html.subtitle1 Style[] (p+position(380,450)) "研究内容"
            html.textA Style[] (p+position(400,550)) "Aqualisのコード→HTML・JavaScriptのコードを生成するライブラリ（関数群）を実装"
            html.subtitle1 Style[] (p+position(380,650)) "結果"
            html.textA Style[] (p+position(400,750)) "数値解析用プログラミング言語（Aqualis）と共通のコードでスライドも作れる"
            html.textA Style[] (p+position(400,800)) "正確な図・アニメーションを効率的に作成可能"