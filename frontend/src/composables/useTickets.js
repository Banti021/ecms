import { ref, inject } from 'vue';

export function useTickets() {
    const apiClient = inject('apiClient');
    if (!apiClient) {
        throw new Error('API client is not provided');
    }

    const tickets = ref([]);
    const ticket = ref(null);
    const error = ref(null);
    const ticketSuccess = ref(false);

    const fetchTickets = async () => {
        try {
            const response = await apiClient.get('/Ticket');
            tickets.value = response.data;
        } catch (err) {
            console.error('Error fetching tickets:', err);
            error.value = err;
        }
    };

    const fetchTicketById = async (id) => {
        try {
            const response = await apiClient.get(`/Ticket/${id}`);
            ticket.value = response.data;
        } catch (err) {
            console.error('Error fetching ticket by ID:', err);
            error.value = err;
        }
    };

    const buyTicket = async (event, ticketType, ticketQuantity, isSeated, seatNumber, authStore) => {
        if (!event) return;

        try {
            await apiClient.post('/Event/register', {
                EventId: event.id,
                CustomerId: authStore.user.id,
                TicketPrice: ticketType === 'vip' ? event.vipPrice : event.regularPrice,
                SeatNumber: isSeated ? seatNumber : '',
                TicketType: ticketType === 'vip' ? 2 : 1
            });

            ticketSuccess.value = true;
        } catch (err) {
            console.error('Failed to buy ticket:', err);
            error.value = err;
        }
    };

    return {
        tickets,
        ticket,
        error,
        ticketSuccess,
        fetchTickets,
        fetchTicketById,
        buyTicket,
    };
}
