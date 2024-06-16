<script setup>
import { ref, onMounted, computed } from 'vue';
import { useRoute } from 'vue-router';
import { useEvents } from '../composables/useEvents';

// Event categories mapping
const eventCategories = {
  1: 'Concert',
  2: 'Workshop',
  3: 'Bowling Tournament',
  4: 'Billard Tournament',
  5: 'Movie Show',
  6: 'Holiday Event'
};

const route = useRoute();
const { event, fetchEvent, error } = useEvents();

const ticketQuantity = ref(1);
const ticketType = ref('regular'); // 'regular' or 'vip'

onMounted(() => {
  fetchEvent(route.params.eventId);
});

const ticketPrice = computed(() => {
  if (!event.value) return 0;
  return ticketType.value === 'vip' ? event.value.vipPrice : event.value.regularPrice;
});

const buyTicket = () => {
  console.log(`Buying ${ticketQuantity.value} ${ticketType.value} tickets for event ${event.value.title}`);
};
</script>

<template>
  <div class="max-w-7xl mx-auto py-8 px-4 sm:px-6 lg:px-8 grid grid-cols-1 md:grid-cols-3 gap-8">
    <div class="md:col-span-2">
      <div v-if="error" class="text-red-500 mb-4">
        Error loading event details.
      </div>
      <div v-if="event" class="bg-white shadow overflow-hidden sm:rounded-lg">
        <div class="px-4 py-5 sm:px-6">
          <h3 class="text-2xl leading-6 font-medium text-gray-900">{{ event.title }}</h3>
          <p class="mt-2 max-w-2xl text-sm text-gray-500">{{ event.description }}</p>
        </div>
        <div class="border-t border-gray-200">
          <dl class="divide-y divide-gray-200">
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">Category</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ eventCategories[event.eventCategory] }}</dd>
            </div>
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">Start Time</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ new Date(event.startTime).toLocaleString() }}</dd>
            </div>
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">End Time</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ new Date(event.endTime).toLocaleString() }}</dd>
            </div>
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">Regular Price</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">${{ event.regularPrice.toFixed(2) }}</dd>
            </div>
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">VIP Price</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">${{ event.vipPrice.toFixed(2) }}</dd>
            </div>
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">Max Attendees</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ event.maxAttendees }}</dd>
            </div>
            <div class="px-4 py-4 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
              <dt class="text-sm font-medium text-gray-500">Current Attendees</dt>
              <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ event.currentAttendees }}</dd>
            </div>
          </dl>
        </div>
      </div>
      <div v-else class="text-center text-gray-500">
        Loading event details...
      </div>
    </div>
    <div>
      <div class="bg-white shadow rounded-lg p-4">
        <h4 class="text-lg font-medium text-gray-900">Buy Tickets</h4>
        <div class="mt-4">
          <label for="ticketType" class="block text-sm font-medium text-gray-700">Ticket Type</label>
          <select id="ticketType" v-model="ticketType" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm">
            <option value="regular">Regular - ${{ event?.regularPrice.toFixed(2) }}</option>
            <option value="vip">VIP - ${{ event?.vipPrice.toFixed(2) }}</option>
          </select>
        </div>
        <div class="mt-4">
          <label for="quantity" class="block text-sm font-medium text-gray-700">Quantity</label>
          <input type="number" id="quantity" v-model="ticketQuantity" min="1" max="10" class="mt-1 block w-full border border-gray-300 rounded-md shadow-sm py-2 px-3 focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm">
        </div>
        <div class="mt-6">
          <p class="text-sm text-gray-500">Total Price: ${{ (ticketPrice * ticketQuantity).toFixed(2) }}</p>
        </div>
        <div class="mt-6">
          <button @click="buyTicket" class="w-full inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500">
            Buy Ticket
          </button>
        </div>
      </div>
    </div>
  </div>
</template>