from disco.bot import Bot, Plugin

"""
Disco github: https://github.com/b1naryth1ef/disco
Documentation: https://b1naryth1ef.github.io/disco/bot_tutorial/first_steps.html
"""

class SimplePlugin(Plugin):
    # Plugins provide an easy interface for listening to Discord events
    @Plugin.listen('ChannelCreate')
    def on_channel_create(self, event):
        event.channel.send_message('Woah, a new channel huh!')

    # They also provide an easy-to-use command component
    @Plugin.command('ping')
    def on_ping_command(self, event):
        event.msg.reply('Pong!')

    # Which includes command argument parsing
    @Plugin.command('echo', '<content:str...>')
    def on_echo_command(self, event, content):
        event.msg.reply(content)