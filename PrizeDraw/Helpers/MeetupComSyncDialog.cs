﻿using PrizeDraw.ViewModels;

namespace PrizeDraw.Helpers
{
    public class MeetupComSyncDialog : IMeetupComSyncDialog
    {
        private readonly MeetupDotComSync _window;
        private readonly MeetupDotComSyncViewModel _viewModel;

        public MeetupComSyncDialog(MeetupDotComSync window, MeetupDotComSyncViewModel viewModel)
        {
            _window = window;
            _window.DataContext = viewModel;
            _viewModel = viewModel;
        }

        public void BeginUpdate(string eventId)
        {
            _viewModel.EventId = eventId;
            _window.ShowDialog();
        }
    }
}