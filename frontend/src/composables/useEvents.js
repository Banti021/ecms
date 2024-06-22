import { ref, inject } from 'vue';

export function useEvents() {
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const events = ref([]);
    const event = ref(null);
    const error = ref(null);

    const fetchEvents = async () => {
        try {
            const response = await apiClient.get('/Event');
            events.value = response.data;
        } catch (err) {
            console.error("API error", err);
            error.value = err;
        }
    };

    const fetchEvent = async (id) => {
        try {
            const response = await apiClient.get(`/Event/${id}`);
            console.log("Event", response.data);
            event.value = response.data;
        } catch (err) {
            console.error("API error", err);
            error.value = err;
        }
    };

    return {
        events,
        event,
        error,
        fetchEvents,
        fetchEvent,
    };
}
