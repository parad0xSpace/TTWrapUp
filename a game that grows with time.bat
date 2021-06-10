@echo off
cls
:start
echo Hey there, future me!
pause
cls
echo You are Griffin, right?
pause
cls
echo Lol I hope so.
pause
cls
echo Anyways.
pause
cls
echo Griff, you made this on the twenty-ninth of March in 2017.
pause
cls
echo You were supposed to be reading, but instead you decided to type up this code.
pause
cls
echo You're still into Voltron, right? (remember, all answers are simple!)
set /p answ=

if %answ% == yes goto good
if %answ% == yeah goto good
if %answ% == nah goto no
if %answ% == no goto no

:no
cls
echo ...
pause
cls
echo You aren't me.
pause
cls
pause
pause
pause
pause
pause
cls
echo Goodbye, traitor.
pause
exit

:good
cls
echo Great! I knew you would come through!
pause
cls
echo Say, who is your favorite paladin right now?
set /p pal=

if %pal% == shiro goto shiro
if %pal% == pidge goto pidge
if %pal% == keith goto keith
if %pal% == lance goto lance
if %pal% == hunk goto hunk

:shiro
cls
echo Shiro, eh?
pause
cls
echo Honestly, I'm not impressed
pause
cls
echo Shiro plays favorites way too often and neglects Lance and Hunk.
echo And I'm not a fan of his character building so far.
echo Still, I like him and an currently concerened about his health.
pause
cls
echo You don't ship sha/ladin, do you?
set /p shal=

if %shal% == yes goto no
if %shal% == no goto mhm

:pidge
cls
echo Ah, Pidge.
pause
cls
echo I'm so in love with her.
pause
cls
echo Sure, I would like to have her character develop more
echo emotion-wise, but for now I'm content the way she is.
pause
cls
echo You do love Pidge, right?
set /p dec=

if %dec% == yes goto mhm
if %dec% == no goto no
:keith
cls
echo Keith, huh?
pause
cls
echo I like Keith a lot too.
pause
cls
echo I don't deny he has flaws. He actually has a lot of them.
echo But for me, a depressed, angsty 14 year old, Keith is pretty relatable.
pause
goto quest
:quest
cls
echo You do ship klance still, right?
set /p klance=

if %klance% == yes goto mhm
if %klance% == no goto no

:lance
cls
echo Ooh! Lance!
pause
cls
echo I've always loved Lance.
pause
cls
echo Even if Pidge is my favorite, he's a tied with Keith for second.
echo He never lets himself portray weakness. He searches
echo for love and meaning everywhere. He, like Keith, is very relatable to this
echo angsty fourteen year old.
pause
goto quest

:hunk
echo Hunk!!
pause
cls
echo I like Hunk as a character, I really do! He's just never
echo made my favorites list because there is so little about him
echo to be guessed. You know who he is as a character right out of
echo the gates, and he doesn't develop much in either season.
echo That's just my opinion.
pause
cls
echo what do you think?
set /p idk=
goto mhm

:wip
cls
echo Well well well.
echo I revisted the game on the eighth of September in 2017
pause
cls
echo Soooo, how are you? Be honest.
set /p mood=
cls
echo Yeah, I'm feeling kinda %mood% too.
pause
cls
echo Well that's all I have to say for now.
echo add something later, okay?
set /p well=

if %well% == yes goto wip2
if %well% == okay goto wip2
if %well% == ok goto wip2
if %well% == no goto no
if %well% == nah goto no
:wip2
cls
echo Sup, Griff!
pause
cls
echo You accesed this again on the 6th of June!
echo You were supposed to be working on a comic but you got stuck.
pause
cls
echo So... You know about Homestuck?
set /p home=

if %home% == yes goto yep
if %home% == no goto no
:yep
echo Oh thanks goodness! I'm not the only cringy one here.
echo Who's your favorite troll? (Of the OG trolls.)
set /p troll=

if %troll% == karkat goto karkat
if %troll% == aradia goto aradia
if %troll% == tavros goto tavros
if %troll% == sollux goto sollux
if %troll% == nepeta goto nepeta
if %troll% == kanaya goto kanaya
if %troll% == terezi goto terezi
if %troll% == vriska goto vriska
if %troll% == equius goto equius
if %troll% == gamzee goto gamzee
if %troll% == eridan goto eridan
if %troll% == feferi goto feferi

:karkat
cls
echo Karkles, huh?
pause
cls
echo I love Karkat! There's so much more
echo to him than what a lot of people
echo give him. I'm glad I didn't
echo become one of those people.
echo I love you, Kat!
pause
goto wip3

:aradia
cls
echo Aradia, huh?
pause
cls
echo Honestly, I din't think too much about Aradia.
echo I think she's a cool character,
echo but the narrative doesn't
echo focus enough on her to make
echo her relevant.
echo Ara, you deserved better!
pause
goto wip3

:tavros
cls
echo Tavros, huh?
pause
cls
echo I really appreciate Tavros.
echo He's not given enough love
echo by Hussie or by the fandom.
echo Yeah, he's a bit cowardly,
echo but he does what's needed
echo when the time comes.
echo Tav, you da troll!
pause
goto wip3

:sollux
cls
echo Sollux, huh?
pause
cls
echo I really like Sollux!
echo He's a cool character,
echo and a patron of my *former*
echo aspect, Doom!
echo I really like hime, not much
echo to say though.
echo Sol; thanks!
pause
goto wip3

:nepeta
cls
echo Nepeta, huh?
pause
cls
echo I really like Nepeta!
echo She's super cute, but
echo like Aradia, there isn't
echo enough of *just* her,
echo not davepetasprite,
echo to make her relevant.
echo Nep, good job!
pause
goto wip3

:kanaya
cls
echo Kanaya, huh?
pause
cls
echo I really like Kanaya, don't get me wrong.
echo But I really don't like her
echo characterization as a background
echo lesbian. It's not fair! She's
echo nuturing, the perfect moirail
echo for my boi Kar, and all around
echo a great character.
echo Kan, I love you! <>
pause
goto wip3

:terezi
echo Terezi, huh?
pause
cls
echo Uh. Can't say I saw that coming.
echo Honestly, Terezi deserves sooo
echo much better than she's given in
echo the comic. She's a lovely
echo character, just underdeveloped.
echo
echo Rezi, you... do.. that.
pause
goto wip3

:vriska
cls
echo ...
echo You're kidding me, right?
pause
cls
echo If you couldn't already tell, I don't
echo like Vriska. She has *few*
echo redeeming qualities and is
echo generally, a bitch.
echo Vriska, rot in hell!
pause
goto wip3

:equius
cls
echo Uh... Wow?
pause
cls
echo Not gonna lie
echo I really don't like Equius.
echo Yeah, I see his finer points
echo but his character just...
echo Rubs me the wrong way.
echo Equihiss- I'm sorry.
pause
goto wip3

:gamzee
cls
echo Gamzee, huh?
echo I get it.
echo Gamzee is our patron.
echo But he's kinda an asshole, in fanon!
echo Plus my ex likes him so...
echo There isn't much of a reason to
echo hate him, but there isn't
echo a reason to like him
echo either.
echo Gam, you a creep!
pause
goto wip3

:eridan
cls
echo Eridan, huh?
pause
cls
echo In fanon, I agree that Eridan
echo isn't bad. He's actually
echo really sweet! But, while
echo he has expreienced a lot
echo of trama in cannon, that
echo doesn't exuse his horrible
echo behavior.
echo ED, chill the heck out man.
pause
goto wip3

:feferi
cls
echo Feferi, huh?
pause
cls
echo While I admit that Feferi
echo is cute, and has good
echo intentions, she just...
echo doesn't get it. She
echo claims to understand
echo what everyone else is going
echo through but really she's just
echo self-centered and
echo dismissive of everyone
echo else's problems.
echo Fef... You tried.
pause
goto wip3

:mhm
echo I knew you would come through!
echo After all, some things just ever change.
pause
cls
echo Take care of yourself, got it?
pause
goto wip

:wip3
cls
echo Well, that's all I felt like doing.
echo Twelve paths is a lot, okay?!?!?
pause
cls
echo Well, see you around. ;)
pause
goto wip4

:wip4
cls
echo Howdy Griff! You accessed this
echo again on the 9th of September in 2018
echo because you were cleaning out files.
pause
cls
echo You're still in to
echo Be More Chill right?
set /p bmc=

if %bmc% == yes goto bmc2
if %bmc% == no goto bmcaw

:bmcaw
cls
echo Aw, that's too bad.
goto bls

:bls
echo Did you at least finish Be Less Single?
set /p bls=

if %bls% == yes goto yus
if %bls% == no goto getonthat

:bmc2
cls
echo Sweet! I really like
echo BMC right now, so I'm
echo glad that stuck.
goto bls

:yus
cls
echo Great! I'm glad :)
goto endwip4

:getonthat
cls
echo What? I want you to finish it!
echo Get on that!!
pause
goto endwip4

:endwip4
cls
echo That's it for now!
echo Update me, okay?
pause
goto why

:why
cls
echo Well it's update time again,
echo here we are on the 20th of November.
echo How've you been?
set /p idc =
cls
echo %idc% huh?
pause
echo I really don't care.
echo I don't even know why I'm updating
echo this when I have nothing to add.
pause
cls
echo Come back when you have something better.
pause
exit