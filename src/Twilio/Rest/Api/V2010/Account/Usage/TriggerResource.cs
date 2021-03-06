using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Usage 
{

    /// <summary>
    /// TriggerResource
    /// </summary>
    public class TriggerResource : Resource 
    {
        public sealed class UsageCategoryEnum : StringEnum 
        {
            private UsageCategoryEnum(string value) : base(value) {}
            public UsageCategoryEnum() {}

            public static readonly UsageCategoryEnum AnsweringMachineDetection = new UsageCategoryEnum("answering-machine-detection");
            public static readonly UsageCategoryEnum AuthyAuthentications = new UsageCategoryEnum("authy-authentications");
            public static readonly UsageCategoryEnum AuthyCallsOutbound = new UsageCategoryEnum("authy-calls-outbound");
            public static readonly UsageCategoryEnum AuthyMonthlyFees = new UsageCategoryEnum("authy-monthly-fees");
            public static readonly UsageCategoryEnum AuthyPhoneIntelligence = new UsageCategoryEnum("authy-phone-intelligence");
            public static readonly UsageCategoryEnum AuthyPhoneVerifications = new UsageCategoryEnum("authy-phone-verifications");
            public static readonly UsageCategoryEnum AuthySmsOutbound = new UsageCategoryEnum("authy-sms-outbound");
            public static readonly UsageCategoryEnum CallProgessEvents = new UsageCategoryEnum("call-progess-events");
            public static readonly UsageCategoryEnum Calleridlookups = new UsageCategoryEnum("calleridlookups");
            public static readonly UsageCategoryEnum Calls = new UsageCategoryEnum("calls");
            public static readonly UsageCategoryEnum CallsClient = new UsageCategoryEnum("calls-client");
            public static readonly UsageCategoryEnum CallsGlobalconference = new UsageCategoryEnum("calls-globalconference");
            public static readonly UsageCategoryEnum CallsInbound = new UsageCategoryEnum("calls-inbound");
            public static readonly UsageCategoryEnum CallsInboundLocal = new UsageCategoryEnum("calls-inbound-local");
            public static readonly UsageCategoryEnum CallsInboundMobile = new UsageCategoryEnum("calls-inbound-mobile");
            public static readonly UsageCategoryEnum CallsInboundTollfree = new UsageCategoryEnum("calls-inbound-tollfree");
            public static readonly UsageCategoryEnum CallsOutbound = new UsageCategoryEnum("calls-outbound");
            public static readonly UsageCategoryEnum CallsRecordings = new UsageCategoryEnum("calls-recordings");
            public static readonly UsageCategoryEnum CallsSip = new UsageCategoryEnum("calls-sip");
            public static readonly UsageCategoryEnum CallsSipInbound = new UsageCategoryEnum("calls-sip-inbound");
            public static readonly UsageCategoryEnum CallsSipOutbound = new UsageCategoryEnum("calls-sip-outbound");
            public static readonly UsageCategoryEnum CarrierLookups = new UsageCategoryEnum("carrier-lookups");
            public static readonly UsageCategoryEnum Conversations = new UsageCategoryEnum("conversations");
            public static readonly UsageCategoryEnum ConversationsApiRequests = new UsageCategoryEnum("conversations-api-requests");
            public static readonly UsageCategoryEnum ConversationsConversationEvents = new UsageCategoryEnum("conversations-conversation-events");
            public static readonly UsageCategoryEnum ConversationsEndpointConnectivity = new UsageCategoryEnum("conversations-endpoint-connectivity");
            public static readonly UsageCategoryEnum ConversationsEvents = new UsageCategoryEnum("conversations-events");
            public static readonly UsageCategoryEnum ConversationsParticipantEvents = new UsageCategoryEnum("conversations-participant-events");
            public static readonly UsageCategoryEnum ConversationsParticipants = new UsageCategoryEnum("conversations-participants");
            public static readonly UsageCategoryEnum Cps = new UsageCategoryEnum("cps");
            public static readonly UsageCategoryEnum IpMessaging = new UsageCategoryEnum("ip-messaging");
            public static readonly UsageCategoryEnum IpMessagingCommands = new UsageCategoryEnum("ip-messaging-commands");
            public static readonly UsageCategoryEnum IpMessagingDataStorage = new UsageCategoryEnum("ip-messaging-data-storage");
            public static readonly UsageCategoryEnum IpMessagingDataTransfer = new UsageCategoryEnum("ip-messaging-data-transfer");
            public static readonly UsageCategoryEnum IpMessagingEndpointConnectivity = new UsageCategoryEnum("ip-messaging-endpoint-connectivity");
            public static readonly UsageCategoryEnum Lookups = new UsageCategoryEnum("lookups");
            public static readonly UsageCategoryEnum Marketplace = new UsageCategoryEnum("marketplace");
            public static readonly UsageCategoryEnum MarketplaceAlgorithmiaNamedEntityRecognition = new UsageCategoryEnum("marketplace-algorithmia-named-entity-recognition");
            public static readonly UsageCategoryEnum MarketplaceDigitalSegmentBusinessInfo = new UsageCategoryEnum("marketplace-digital-segment-business-info");
            public static readonly UsageCategoryEnum MarketplaceGoogleSpeechToText = new UsageCategoryEnum("marketplace-google-speech-to-text");
            public static readonly UsageCategoryEnum MarketplaceIbmWatsonMessageInsights = new UsageCategoryEnum("marketplace-ibm-watson-message-insights");
            public static readonly UsageCategoryEnum MarketplaceIbmWatsonMessageSentiment = new UsageCategoryEnum("marketplace-ibm-watson-message-sentiment");
            public static readonly UsageCategoryEnum MarketplaceIbmWatsonRecordingAnalysis = new UsageCategoryEnum("marketplace-ibm-watson-recording-analysis");
            public static readonly UsageCategoryEnum MarketplaceIcehookSystemsScout = new UsageCategoryEnum("marketplace-icehook-systems-scout");
            public static readonly UsageCategoryEnum MarketplaceInfogroupDataaxleBizinfo = new UsageCategoryEnum("marketplace-infogroup-dataaxle-bizinfo");
            public static readonly UsageCategoryEnum MarketplaceMarchexCleancall = new UsageCategoryEnum("marketplace-marchex-cleancall");
            public static readonly UsageCategoryEnum MarketplaceMarchexSentimentAnalysisForSms = new UsageCategoryEnum("marketplace-marchex-sentiment-analysis-for-sms");
            public static readonly UsageCategoryEnum MarketplaceMarketplaceNextcallerSocialId = new UsageCategoryEnum("marketplace-marketplace-nextcaller-social-id");
            public static readonly UsageCategoryEnum MarketplaceMobileCommonsOptOutClassifier = new UsageCategoryEnum("marketplace-mobile-commons-opt-out-classifier");
            public static readonly UsageCategoryEnum MarketplaceNexiwaveVoicemailToText = new UsageCategoryEnum("marketplace-nexiwave-voicemail-to-text");
            public static readonly UsageCategoryEnum MarketplaceNextcallerAdvancedCallerIdentification = new UsageCategoryEnum("marketplace-nextcaller-advanced-caller-identification");
            public static readonly UsageCategoryEnum MarketplaceNomoroboSpamScore = new UsageCategoryEnum("marketplace-nomorobo-spam-score");
            public static readonly UsageCategoryEnum MarketplacePayfoneTcpaCompliance = new UsageCategoryEnum("marketplace-payfone-tcpa-compliance");
            public static readonly UsageCategoryEnum MarketplaceTeloOpencnam = new UsageCategoryEnum("marketplace-telo-opencnam");
            public static readonly UsageCategoryEnum MarketplaceTruecnamTrueSpam = new UsageCategoryEnum("marketplace-truecnam-true-spam");
            public static readonly UsageCategoryEnum MarketplaceTwilioCallerNameLookupUs = new UsageCategoryEnum("marketplace-twilio-caller-name-lookup-us");
            public static readonly UsageCategoryEnum MarketplaceTwilioCarrierInformationLookup = new UsageCategoryEnum("marketplace-twilio-carrier-information-lookup");
            public static readonly UsageCategoryEnum MarketplaceVoicebasePci = new UsageCategoryEnum("marketplace-voicebase-pci");
            public static readonly UsageCategoryEnum MarketplaceVoicebaseTranscription = new UsageCategoryEnum("marketplace-voicebase-transcription");
            public static readonly UsageCategoryEnum MarketplaceWhitepagesProCallerIdentification = new UsageCategoryEnum("marketplace-whitepages-pro-caller-identification");
            public static readonly UsageCategoryEnum MarketplaceWhitepagesProPhoneIntelligence = new UsageCategoryEnum("marketplace-whitepages-pro-phone-intelligence");
            public static readonly UsageCategoryEnum MarketplaceWhitepagesProPhoneReputation = new UsageCategoryEnum("marketplace-whitepages-pro-phone-reputation");
            public static readonly UsageCategoryEnum MarketplaceWolframShortAnswer = new UsageCategoryEnum("marketplace-wolfram-short-answer");
            public static readonly UsageCategoryEnum MarketplaceWolfarmSpokenResults = new UsageCategoryEnum("marketplace-wolfarm-spoken-results");
            public static readonly UsageCategoryEnum MarketplaceDeepgramPhraseDetector = new UsageCategoryEnum("marketplace-deepgram-phrase-detector");
            public static readonly UsageCategoryEnum MarketplaceConvrizaAbaba = new UsageCategoryEnum("marketplace-convriza-ababa");
            public static readonly UsageCategoryEnum MarketplaceIbmWatsonToneAnalyzer = new UsageCategoryEnum("marketplace-ibm-watson-tone-analyzer");
            public static readonly UsageCategoryEnum MarketplaceRemeetingAutomaticSpeechRecognition = new UsageCategoryEnum("marketplace-remeeting-automatic-speech-recognition");
            public static readonly UsageCategoryEnum MarketplaceTcpaDefenseSolutionsBlacklistFeed = new UsageCategoryEnum("marketplace-tcpa-defense-solutions-blacklist-feed");
            public static readonly UsageCategoryEnum Mediastorage = new UsageCategoryEnum("mediastorage");
            public static readonly UsageCategoryEnum Mms = new UsageCategoryEnum("mms");
            public static readonly UsageCategoryEnum MmsInbound = new UsageCategoryEnum("mms-inbound");
            public static readonly UsageCategoryEnum MmsInboundLongcode = new UsageCategoryEnum("mms-inbound-longcode");
            public static readonly UsageCategoryEnum MmsInboundShortcode = new UsageCategoryEnum("mms-inbound-shortcode");
            public static readonly UsageCategoryEnum MmsOutbound = new UsageCategoryEnum("mms-outbound");
            public static readonly UsageCategoryEnum MmsOutboundLongcode = new UsageCategoryEnum("mms-outbound-longcode");
            public static readonly UsageCategoryEnum MmsOutboundShortcode = new UsageCategoryEnum("mms-outbound-shortcode");
            public static readonly UsageCategoryEnum MonitorReads = new UsageCategoryEnum("monitor-reads");
            public static readonly UsageCategoryEnum MonitorStorage = new UsageCategoryEnum("monitor-storage");
            public static readonly UsageCategoryEnum MonitorWrites = new UsageCategoryEnum("monitor-writes");
            public static readonly UsageCategoryEnum Notify = new UsageCategoryEnum("notify");
            public static readonly UsageCategoryEnum NotifyActionsAttempts = new UsageCategoryEnum("notify-actions-attempts");
            public static readonly UsageCategoryEnum NotifyChannels = new UsageCategoryEnum("notify-channels");
            public static readonly UsageCategoryEnum NumberFormatLookups = new UsageCategoryEnum("number-format-lookups");
            public static readonly UsageCategoryEnum Pchat = new UsageCategoryEnum("pchat");
            public static readonly UsageCategoryEnum PchatActions = new UsageCategoryEnum("pchat-actions");
            public static readonly UsageCategoryEnum PchatAps = new UsageCategoryEnum("pchat-aps");
            public static readonly UsageCategoryEnum PchatNotifications = new UsageCategoryEnum("pchat-notifications");
            public static readonly UsageCategoryEnum PchatReads = new UsageCategoryEnum("pchat-reads");
            public static readonly UsageCategoryEnum PchatUsers = new UsageCategoryEnum("pchat-users");
            public static readonly UsageCategoryEnum PchatMessages = new UsageCategoryEnum("pchat-messages");
            public static readonly UsageCategoryEnum Pfax = new UsageCategoryEnum("pfax");
            public static readonly UsageCategoryEnum PfaxMinutes = new UsageCategoryEnum("pfax-minutes");
            public static readonly UsageCategoryEnum PfaxMinutesInbound = new UsageCategoryEnum("pfax-minutes-inbound");
            public static readonly UsageCategoryEnum PfaxMinutesOutbound = new UsageCategoryEnum("pfax-minutes-outbound");
            public static readonly UsageCategoryEnum PfaxPages = new UsageCategoryEnum("pfax-pages");
            public static readonly UsageCategoryEnum Phonenumbers = new UsageCategoryEnum("phonenumbers");
            public static readonly UsageCategoryEnum PhonenumbersCps = new UsageCategoryEnum("phonenumbers-cps");
            public static readonly UsageCategoryEnum PhonenumbersEmergency = new UsageCategoryEnum("phonenumbers-emergency");
            public static readonly UsageCategoryEnum PhonenumbersLocal = new UsageCategoryEnum("phonenumbers-local");
            public static readonly UsageCategoryEnum PhonenumbersMobile = new UsageCategoryEnum("phonenumbers-mobile");
            public static readonly UsageCategoryEnum PhonenumbersSetups = new UsageCategoryEnum("phonenumbers-setups");
            public static readonly UsageCategoryEnum PhonenumbersTollfree = new UsageCategoryEnum("phonenumbers-tollfree");
            public static readonly UsageCategoryEnum Premiumsupport = new UsageCategoryEnum("premiumsupport");
            public static readonly UsageCategoryEnum Pv = new UsageCategoryEnum("pv");
            public static readonly UsageCategoryEnum PvRoomParticipants = new UsageCategoryEnum("pv-room-participants");
            public static readonly UsageCategoryEnum PvRoomParticipantsAu1 = new UsageCategoryEnum("pv-room-participants-au1");
            public static readonly UsageCategoryEnum PvRoomParticipantsBr1 = new UsageCategoryEnum("pv-room-participants-br1");
            public static readonly UsageCategoryEnum PvRoomParticipantsIe1 = new UsageCategoryEnum("pv-room-participants-ie1");
            public static readonly UsageCategoryEnum PvRoomParticipantsJp1 = new UsageCategoryEnum("pv-room-participants-jp1");
            public static readonly UsageCategoryEnum PvRoomParticipantsSg1 = new UsageCategoryEnum("pv-room-participants-sg1");
            public static readonly UsageCategoryEnum PvRoomParticipantsUs1 = new UsageCategoryEnum("pv-room-participants-us1");
            public static readonly UsageCategoryEnum PvRoomParticipantsUs2 = new UsageCategoryEnum("pv-room-participants-us2");
            public static readonly UsageCategoryEnum PvRooms = new UsageCategoryEnum("pv-rooms");
            public static readonly UsageCategoryEnum PvSipEndpointRegistrations = new UsageCategoryEnum("pv-sip-endpoint-registrations");
            public static readonly UsageCategoryEnum Recordings = new UsageCategoryEnum("recordings");
            public static readonly UsageCategoryEnum Recordingstorage = new UsageCategoryEnum("recordingstorage");
            public static readonly UsageCategoryEnum Shortcodes = new UsageCategoryEnum("shortcodes");
            public static readonly UsageCategoryEnum ShortcodesCustomerowned = new UsageCategoryEnum("shortcodes-customerowned");
            public static readonly UsageCategoryEnum ShortcodesMmsEnablement = new UsageCategoryEnum("shortcodes-mms-enablement");
            public static readonly UsageCategoryEnum ShortcodesMps = new UsageCategoryEnum("shortcodes-mps");
            public static readonly UsageCategoryEnum ShortcodesRandom = new UsageCategoryEnum("shortcodes-random");
            public static readonly UsageCategoryEnum ShortcodesUk = new UsageCategoryEnum("shortcodes-uk");
            public static readonly UsageCategoryEnum ShortcodesVanity = new UsageCategoryEnum("shortcodes-vanity");
            public static readonly UsageCategoryEnum Sms = new UsageCategoryEnum("sms");
            public static readonly UsageCategoryEnum SmsInbound = new UsageCategoryEnum("sms-inbound");
            public static readonly UsageCategoryEnum SmsInboundLongcode = new UsageCategoryEnum("sms-inbound-longcode");
            public static readonly UsageCategoryEnum SmsInboundShortcode = new UsageCategoryEnum("sms-inbound-shortcode");
            public static readonly UsageCategoryEnum SmsOutbound = new UsageCategoryEnum("sms-outbound");
            public static readonly UsageCategoryEnum SmsOutboundContentInspection = new UsageCategoryEnum("sms-outbound-content-inspection");
            public static readonly UsageCategoryEnum SmsOutboundLongcode = new UsageCategoryEnum("sms-outbound-longcode");
            public static readonly UsageCategoryEnum SmsOutboundShortcode = new UsageCategoryEnum("sms-outbound-shortcode");
            public static readonly UsageCategoryEnum SmsMessagesFeatures = new UsageCategoryEnum("sms-messages-features");
            public static readonly UsageCategoryEnum TaskrouterTasks = new UsageCategoryEnum("taskrouter-tasks");
            public static readonly UsageCategoryEnum Totalprice = new UsageCategoryEnum("totalprice");
            public static readonly UsageCategoryEnum Transcriptions = new UsageCategoryEnum("transcriptions");
            public static readonly UsageCategoryEnum TrunkingCps = new UsageCategoryEnum("trunking-cps");
            public static readonly UsageCategoryEnum TrunkingEmergencyCalls = new UsageCategoryEnum("trunking-emergency-calls");
            public static readonly UsageCategoryEnum TrunkingOrigination = new UsageCategoryEnum("trunking-origination");
            public static readonly UsageCategoryEnum TrunkingOriginationLocal = new UsageCategoryEnum("trunking-origination-local");
            public static readonly UsageCategoryEnum TrunkingOriginationMobile = new UsageCategoryEnum("trunking-origination-mobile");
            public static readonly UsageCategoryEnum TrunkingOriginationTollfree = new UsageCategoryEnum("trunking-origination-tollfree");
            public static readonly UsageCategoryEnum TrunkingRecordings = new UsageCategoryEnum("trunking-recordings");
            public static readonly UsageCategoryEnum TrunkingSecure = new UsageCategoryEnum("trunking-secure");
            public static readonly UsageCategoryEnum TrunkingTermination = new UsageCategoryEnum("trunking-termination");
            public static readonly UsageCategoryEnum Turnmegabytes = new UsageCategoryEnum("turnmegabytes");
            public static readonly UsageCategoryEnum TurnmegabytesAustralia = new UsageCategoryEnum("turnmegabytes-australia");
            public static readonly UsageCategoryEnum TurnmegabytesBrasil = new UsageCategoryEnum("turnmegabytes-brasil");
            public static readonly UsageCategoryEnum TurnmegabytesIreland = new UsageCategoryEnum("turnmegabytes-ireland");
            public static readonly UsageCategoryEnum TurnmegabytesJapan = new UsageCategoryEnum("turnmegabytes-japan");
            public static readonly UsageCategoryEnum TurnmegabytesSingapore = new UsageCategoryEnum("turnmegabytes-singapore");
            public static readonly UsageCategoryEnum TurnmegabytesUseast = new UsageCategoryEnum("turnmegabytes-useast");
            public static readonly UsageCategoryEnum TurnmegabytesUswest = new UsageCategoryEnum("turnmegabytes-uswest");
            public static readonly UsageCategoryEnum TwilioInterconnect = new UsageCategoryEnum("twilio-interconnect");
            public static readonly UsageCategoryEnum VoiceInsights = new UsageCategoryEnum("voice-insights");
            public static readonly UsageCategoryEnum Wireless = new UsageCategoryEnum("wireless");
            public static readonly UsageCategoryEnum WirelessOrders = new UsageCategoryEnum("wireless-orders");
            public static readonly UsageCategoryEnum WirelessOrdersBulk = new UsageCategoryEnum("wireless-orders-bulk");
            public static readonly UsageCategoryEnum WirelessOrdersEsim = new UsageCategoryEnum("wireless-orders-esim");
            public static readonly UsageCategoryEnum WirelessOrdersStarter = new UsageCategoryEnum("wireless-orders-starter");
            public static readonly UsageCategoryEnum WirelessUsage = new UsageCategoryEnum("wireless-usage");
            public static readonly UsageCategoryEnum WirelessUsageCommands = new UsageCategoryEnum("wireless-usage-commands");
            public static readonly UsageCategoryEnum WirelessUsageCommandsHome = new UsageCategoryEnum("wireless-usage-commands-home");
            public static readonly UsageCategoryEnum WirelessUsageCommandsRoaming = new UsageCategoryEnum("wireless-usage-commands-roaming");
            public static readonly UsageCategoryEnum WirelessUsageData = new UsageCategoryEnum("wireless-usage-data");
            public static readonly UsageCategoryEnum WirelessUsageDataCustomAdditionalmb = new UsageCategoryEnum("wireless-usage-data-custom-additionalmb");
            public static readonly UsageCategoryEnum WirelessUsageDataCustomFirst5Mb = new UsageCategoryEnum("wireless-usage-data-custom-first5mb");
            public static readonly UsageCategoryEnum WirelessUsageDataDomesticRoaming = new UsageCategoryEnum("wireless-usage-data-domestic-roaming");
            public static readonly UsageCategoryEnum WirelessUsageDataIndividualAdditionalgb = new UsageCategoryEnum("wireless-usage-data-individual-additionalgb");
            public static readonly UsageCategoryEnum WirelessUsageDataIndividualFirstgb = new UsageCategoryEnum("wireless-usage-data-individual-firstgb");
            public static readonly UsageCategoryEnum WirelessUsageDataInternationalRoamingCanada = new UsageCategoryEnum("wireless-usage-data-international-roaming-canada");
            public static readonly UsageCategoryEnum WirelessUsageDataInternationalRoamingIndia = new UsageCategoryEnum("wireless-usage-data-international-roaming-india");
            public static readonly UsageCategoryEnum WirelessUsageDataInternationalRoamingMexico = new UsageCategoryEnum("wireless-usage-data-international-roaming-mexico");
            public static readonly UsageCategoryEnum WirelessUsageDataPooled = new UsageCategoryEnum("wireless-usage-data-pooled");
            public static readonly UsageCategoryEnum WirelessUsageDataPooledDownlink = new UsageCategoryEnum("wireless-usage-data-pooled-downlink");
            public static readonly UsageCategoryEnum WirelessUsageDataPooledUplink = new UsageCategoryEnum("wireless-usage-data-pooled-uplink");
            public static readonly UsageCategoryEnum WirelessUsageMrc = new UsageCategoryEnum("wireless-usage-mrc");
            public static readonly UsageCategoryEnum WirelessUsageMrcCustom = new UsageCategoryEnum("wireless-usage-mrc-custom");
            public static readonly UsageCategoryEnum WirelessUsageMrcIndividual = new UsageCategoryEnum("wireless-usage-mrc-individual");
            public static readonly UsageCategoryEnum WirelessUsageMrcPooled = new UsageCategoryEnum("wireless-usage-mrc-pooled");
            public static readonly UsageCategoryEnum Sync = new UsageCategoryEnum("sync");
        }

        public sealed class RecurringEnum : StringEnum 
        {
            private RecurringEnum(string value) : base(value) {}
            public RecurringEnum() {}

            public static readonly RecurringEnum Daily = new RecurringEnum("daily");
            public static readonly RecurringEnum Monthly = new RecurringEnum("monthly");
            public static readonly RecurringEnum Yearly = new RecurringEnum("yearly");
            public static readonly RecurringEnum Alltime = new RecurringEnum("alltime");
        }

        public sealed class TriggerFieldEnum : StringEnum 
        {
            private TriggerFieldEnum(string value) : base(value) {}
            public TriggerFieldEnum() {}

            public static readonly TriggerFieldEnum Count = new TriggerFieldEnum("count");
            public static readonly TriggerFieldEnum Usage = new TriggerFieldEnum("usage");
            public static readonly TriggerFieldEnum Price = new TriggerFieldEnum("price");
        }

        private static Request BuildFetchRequest(FetchTriggerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Usage/Triggers/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch and instance of a usage-trigger
        /// </summary>
        ///
        /// <param name="options"> Fetch Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static TriggerResource Fetch(FetchTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch and instance of a usage-trigger
        /// </summary>
        ///
        /// <param name="options"> Fetch Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<TriggerResource> FetchAsync(FetchTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch and instance of a usage-trigger
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique usage-trigger Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static TriggerResource Fetch(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchTriggerOptions(pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch and instance of a usage-trigger
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique usage-trigger Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<TriggerResource> FetchAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchTriggerOptions(pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateTriggerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Usage/Triggers/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update an instance of a usage trigger
        /// </summary>
        ///
        /// <param name="options"> Update Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static TriggerResource Update(UpdateTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update an instance of a usage trigger
        /// </summary>
        ///
        /// <param name="options"> Update Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<TriggerResource> UpdateAsync(UpdateTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update an instance of a usage trigger
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="callbackMethod"> HTTP method to use with callback_url </param>
        /// <param name="callbackUrl"> URL Twilio will request when the trigger fires </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static TriggerResource Update(string pathSid, string pathAccountSid = null, Twilio.Http.HttpMethod callbackMethod = null, Uri callbackUrl = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateTriggerOptions(pathSid){PathAccountSid = pathAccountSid, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, FriendlyName = friendlyName};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update an instance of a usage trigger
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="callbackMethod"> HTTP method to use with callback_url </param>
        /// <param name="callbackUrl"> URL Twilio will request when the trigger fires </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<TriggerResource> UpdateAsync(string pathSid, string pathAccountSid = null, Twilio.Http.HttpMethod callbackMethod = null, Uri callbackUrl = null, string friendlyName = null, ITwilioRestClient client = null)
        {
            var options = new UpdateTriggerOptions(pathSid){PathAccountSid = pathAccountSid, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteTriggerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Usage/Triggers/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static bool Delete(DeleteTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static bool Delete(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteTriggerOptions(pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteTriggerOptions(pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateTriggerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Usage/Triggers.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new UsageTrigger
        /// </summary>
        ///
        /// <param name="options"> Create Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static TriggerResource Create(CreateTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new UsageTrigger
        /// </summary>
        ///
        /// <param name="options"> Create Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<TriggerResource> CreateAsync(CreateTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new UsageTrigger
        /// </summary>
        ///
        /// <param name="callbackUrl"> URL Twilio will request when the trigger fires </param>
        /// <param name="triggerValue"> the value at which the trigger will fire </param>
        /// <param name="usageCategory"> The usage category the trigger watches </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="callbackMethod"> HTTP method to use with callback_url </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="recurring"> How this trigger recurs </param>
        /// <param name="triggerBy"> The field in the UsageRecord that fires the trigger </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static TriggerResource Create(Uri callbackUrl, string triggerValue, TriggerResource.UsageCategoryEnum usageCategory, string pathAccountSid = null, Twilio.Http.HttpMethod callbackMethod = null, string friendlyName = null, TriggerResource.RecurringEnum recurring = null, TriggerResource.TriggerFieldEnum triggerBy = null, ITwilioRestClient client = null)
        {
            var options = new CreateTriggerOptions(callbackUrl, triggerValue, usageCategory){PathAccountSid = pathAccountSid, CallbackMethod = callbackMethod, FriendlyName = friendlyName, Recurring = recurring, TriggerBy = triggerBy};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new UsageTrigger
        /// </summary>
        ///
        /// <param name="callbackUrl"> URL Twilio will request when the trigger fires </param>
        /// <param name="triggerValue"> the value at which the trigger will fire </param>
        /// <param name="usageCategory"> The usage category the trigger watches </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="callbackMethod"> HTTP method to use with callback_url </param>
        /// <param name="friendlyName"> A user-specified, human-readable name for the trigger. </param>
        /// <param name="recurring"> How this trigger recurs </param>
        /// <param name="triggerBy"> The field in the UsageRecord that fires the trigger </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<TriggerResource> CreateAsync(Uri callbackUrl, string triggerValue, TriggerResource.UsageCategoryEnum usageCategory, string pathAccountSid = null, Twilio.Http.HttpMethod callbackMethod = null, string friendlyName = null, TriggerResource.RecurringEnum recurring = null, TriggerResource.TriggerFieldEnum triggerBy = null, ITwilioRestClient client = null)
        {
            var options = new CreateTriggerOptions(callbackUrl, triggerValue, usageCategory){PathAccountSid = pathAccountSid, CallbackMethod = callbackMethod, FriendlyName = friendlyName, Recurring = recurring, TriggerBy = triggerBy};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadTriggerOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Usage/Triggers.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of usage-triggers belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static ResourceSet<TriggerResource> Read(ReadTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<TriggerResource>.FromJson("usage_triggers", response.Content);
            return new ResourceSet<TriggerResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of usage-triggers belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Trigger parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TriggerResource>> ReadAsync(ReadTriggerOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TriggerResource>.FromJson("usage_triggers", response.Content);
            return new ResourceSet<TriggerResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of usage-triggers belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="recurring"> Filter by recurring </param>
        /// <param name="triggerBy"> Filter by trigger by </param>
        /// <param name="usageCategory"> Filter by Usage Category </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Trigger </returns> 
        public static ResourceSet<TriggerResource> Read(string pathAccountSid = null, TriggerResource.RecurringEnum recurring = null, TriggerResource.TriggerFieldEnum triggerBy = null, TriggerResource.UsageCategoryEnum usageCategory = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTriggerOptions{PathAccountSid = pathAccountSid, Recurring = recurring, TriggerBy = triggerBy, UsageCategory = usageCategory, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of usage-triggers belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="recurring"> Filter by recurring </param>
        /// <param name="triggerBy"> Filter by trigger by </param>
        /// <param name="usageCategory"> Filter by Usage Category </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Trigger </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TriggerResource>> ReadAsync(string pathAccountSid = null, TriggerResource.RecurringEnum recurring = null, TriggerResource.TriggerFieldEnum triggerBy = null, TriggerResource.UsageCategoryEnum usageCategory = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadTriggerOptions{PathAccountSid = pathAccountSid, Recurring = recurring, TriggerBy = triggerBy, UsageCategory = usageCategory, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<TriggerResource> NextPage(Page<TriggerResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TriggerResource>.FromJson("usage_triggers", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a TriggerResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TriggerResource object represented by the provided JSON </returns> 
        public static TriggerResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TriggerResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account this trigger monitors.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The api_version
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// HTTP method to use with callback_url
        /// </summary>
        [JsonProperty("callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod CallbackMethod { get; private set; }
        /// <summary>
        /// URL Twilio will request when the trigger fires
        /// </summary>
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }
        /// <summary>
        /// The current value of the field the trigger is watching.
        /// </summary>
        [JsonProperty("current_value")]
        public string CurrentValue { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date the trigger was last fired
        /// </summary>
        [JsonProperty("date_fired")]
        public DateTime? DateFired { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A user-specified, human-readable name for the trigger.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// How this trigger recurs
        /// </summary>
        [JsonProperty("recurring")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TriggerResource.RecurringEnum Recurring { get; private set; }
        /// <summary>
        /// The trigger's unique Sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The field in the UsageRecord that fires the trigger
        /// </summary>
        [JsonProperty("trigger_by")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TriggerResource.TriggerFieldEnum TriggerBy { get; private set; }
        /// <summary>
        /// the value at which the trigger will fire
        /// </summary>
        [JsonProperty("trigger_value")]
        public string TriggerValue { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// The usage category the trigger watches
        /// </summary>
        [JsonProperty("usage_category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TriggerResource.UsageCategoryEnum UsageCategory { get; private set; }
        /// <summary>
        /// The URI of the UsageRecord this trigger is watching
        /// </summary>
        [JsonProperty("usage_record_uri")]
        public string UsageRecordUri { get; private set; }

        private TriggerResource()
        {

        }
    }

}