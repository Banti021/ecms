<script setup>
import { onMounted } from 'vue';
import { useAuthStore } from '../store/auth';
import { useReservations } from '../composables/useReservations';
import { useTickets } from '../composables/useTickets';

const authStore = useAuthStore();
const { user, fetchUser } = authStore;

const { reservations, fetchReservations, error: reservationsError } = useReservations();
const { tickets, fetchTickets, error: ticketsError} = useTickets();

onMounted(() => {
  fetchUser();
  fetchReservations();
  fetchTickets();
});
</script>

<template>
  <div class="max-w-7xl mx-auto py-8 px-4 sm:px-6 lg:px-8">
    <div class="bg-white shadow overflow-hidden sm:rounded-lg">
      <div class="px-4 py-5 sm:px-6">
        <h3 class="text-lg leading-6 font-medium text-gray-900">User Profile</h3>
        <p class="mt-1 max-w-2xl text-sm text-gray-500">Personal details and application.</p>
      </div>
      <div class="border-t border-gray-200">
        <dl>
          <div class="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
            <dt class="text-sm font-medium text-gray-500">Username</dt>
            <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ user?.userName }}</dd>
          </div>
          <div class="bg-white px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
            <dt class="text-sm font-medium text-gray-500">Full Name</dt>
            <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ user?.firstName }} {{ user?.lastName }}</dd>
          </div>
          <div class="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
            <dt class="text-sm font-medium text-gray-500">Email</dt>
            <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ user?.email }}</dd>
          </div>
          <div class="bg-white px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
            <dt class="text-sm font-medium text-gray-500">Phone Number</dt>
            <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ user?.phoneNumber }}</dd>
          </div>
          <div class="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
            <dt class="text-sm font-medium text-gray-500">Role</dt>
            <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ user?.role }}</dd>
          </div>
        </dl>
      </div>
    </div>

    <div class="mt-8">
      <h2 class="text-lg leading-6 font-medium text-gray-900">Reservations</h2>
      <div v-if="reservationsError" class="text-red-500 mb-4">Error loading reservations.</div>
      <div v-else class="mt-4">
        <div v-if="reservations.length" class="bg-white shadow overflow-hidden sm:rounded-lg">
          <div class="border-t border-gray-200">
            <dl>
              <div v-for="reservation in reservations" :key="reservation.id"
                   class="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                <dt class="text-sm font-medium text-gray-500">Reservation ID</dt>
                <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ reservation.id }}</dd>
                <dt class="text-sm font-medium text-gray-500">Status</dt>
                <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ reservation.status }}</dd>
              </div>
            </dl>
          </div>
        </div>
        <div v-else class="text-gray-500">No reservations found.</div>
      </div>
    </div>

    <div class="mt-8">
      <h2 class="text-lg leading-6 font-medium text-gray-900">Tickets</h2>
      <div v-if="ticketsError" class="text-red-500 mb-4">Error loading tickets.</div>
      <div v-else class="mt-4">
        <div v-if="tickets.length" class="bg-white shadow overflow-hidden sm:rounded-lg">
          <div class="border-t border-gray-200">
            <dl>
              <div v-for="ticket in tickets" :key="ticket.id"
                   class="bg-gray-50 px-4 py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6">
                <dt class="text-sm font-medium text-gray-500">Ticket ID</dt>
                <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ ticket.id }}</dd>
                <dt class="text-sm font-medium text-gray-500">Event</dt>
                <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ ticket.event.title }}</dd>
                <dt class="text-sm font-medium text-gray-500">Type</dt>
                <dd class="mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2">{{ ticket.type }}</dd>
              </div>
            </dl>
          </div>
        </div>
        <div v-else class="text-gray-500">No tickets found.</div>
      </div>
    </div>
  </div>
</template>
