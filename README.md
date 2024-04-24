# TIKTOK-TTS FOR UNITY
tiktok-tts in Unity, based on https://github.com/Steve0929/tiktok-tts

### USAGE
- Login or register to tiktok website: https://www.tiktok.com
- Once logged in, open browser developer tools (press F12 key)
- Firefox: Click "Storage", then "Cookies"
- find "sessionid" value
- find "store-idc" value (this is your server/region)
- Edit SECRETS.cs in project, add your sessionid
- Test!
- If you get errors, then open TikTokTTS.cs and your modify BASE_URL value (especially if its different region than the provided one)
- Check list for servers: https://gist.github.com/RupGautam/e6953b6e0a68ece63e6721309135190f
- Test which one works for your server/region (look for ones with api***-normal-c-***.tiktokv.com)

### SAMPLE AUDIO
- https://soundcloud.com/user-689598301/tiktok-tts-sample

### BLOG POST
- (todo)
