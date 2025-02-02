import { ObjectSerializer, EventCallbackHelper } from "@dropbox/sign";

// use your API key
const api_key = '324e3b0840f065eb51f3fd63231d0d33daa35d4ed10d27718839e81737065782';

// callback_data represents data we send to you
const callback_data = {
  'event': {
    'event_type': 'account_confirmed',
    'event_time': '1669926463',
    'event_hash': 'ff8b03439122f9160500c3fb855bdee5a9ccba5fff27d3b258745d8f3074832f',
    'event_metadata': {
      'related_signature_id': null,
      'reported_for_account_id': '6421d70b9bd45059fa207d03ab8d1b96515b472c',
      'reported_for_app_id': null,
      'event_message': null,
    },
  },
};

const callback_event = ObjectSerializer.deserialize(
  callback_data,
  'EventCallbackRequest',
);

// verify that a callback came from HelloSign.com
if (EventCallbackHelper.isValid(api_key, callback_event)) {
  // one of "account_callback" or "api_app_callback"
  const callback_type = EventCallbackHelper.getCallbackType(callback_event);

  // do your magic below!
}
