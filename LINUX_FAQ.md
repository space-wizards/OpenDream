OpenDream RobustToolbox testing was done on Windows so I'm left to clean up.

Here's just some stuff you should know.

## Compile errors involving RobustToolbox stuff

You probably need to update RobustToolbox, cd over there, `git pull master`, `git submodule update --init --recursive`

## Known-good CEF build

`https://cef-builds.spotifycdn.com/cef_binary_91.1.6%2Bg8a752eb%2Bchromium-91.0.4472.77_linux64_beta_minimal.tar.bz2`

Add the Release directory to LD\_LIBRARY\_PATH

## Unable to map ICU file

Copy it into Release (I just copied everything from Resources)

## Various errors about locale files & PAKs

Also copy everything from Resources into directory of application (or maybe current directory???)

## Where's DMCompiler thingy

DMCompiler/bin/Debug (...)

## How the hell do I connect

for me my command line was:

```
LD_LIBRARY_PATH=/media/20kdc/6d58dae8-1885-49fc-a0c2-ad587ec9e7b9/External2/cef_binary_91.1.6+g8a752eb+chromium-91.0.4472.77_linux64_beta_minimal/Release ./Content.Client --connect --connect-address localhost:25566
```

port might change, IDK

