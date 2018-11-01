from disco.bot import Bot, Plugin
from .data import get_user_data

magic_string = '-' * 32

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

    # Get the events for the current user
    @Plugin.command('events', '<content:str...>')
    def on_events_command(self, event, content):
        user = get_user_data(str(event.msg.author))

        builder = magic_string + '\n'
        for schedule_event in user.Events:
            builder += f'Subject: {schedule_event.Subject}\nDescription: {schedule_event.Description}\n'
            builder += magic_string + '\n'

        event.msg.reply(builder)
